PROJECT_NAME := yandex Package

SHELL               := /bin/bash
PACK                := yandex
PROJECT             := github.com/heyzling/pulumi-yandex.git
NODE_MODULE_NAME    := @yandex/${PACK}
TF_NAME             := ${PACK}
PROVIDER_PATH       := provider
VERSION_PATH        := ${PROVIDER_PATH}/pkg/version.Version

TFGEN               := pulumi-tfgen-${PACK}
PROVIDER            := pulumi-resource-${PACK}
VERSION             := $(shell pulumictl get version)

TESTPARALLELISM     := 4

WORKING_DIR         := $(shell pwd)

OS                  := $(shell uname)
OS_LOWER            := $(shell uname | tr '[:upper:]' '[:lower:]')
EMPTY_TO_AVOID_SED  := 
SEMVER_REGEX        := ^v[0-9]+\.[0-9]+\.[0-9]+$

ARCH_NAME           := amd64
PACKAGE_NAME        := pulumi-resource-${PACK}-v${VERSION}-${OS_LOWER}-${ARCH_NAME}.tar.gz
PACKAGE_PATH        := ${WORKING_DIR}/bin/${PACKAGE_NAME}

prepare::
	@if test -z "${NAME}"; then echo "NAME not set"; exit 1; fi
	@if test -z "${REPOSITORY}"; then echo "REPOSITORY not set"; exit 1; fi
	@if test -z "${ORG}"; then echo "ORG not set"; exit 1; fi
	@if test ! -d "provider/cmd/pulumi-tfgen-x${EMPTY_TO_AVOID_SED}yz"; then echo "Project already prepared"; exit 1; fi

	mv "provider/cmd/pulumi-tfgen-x${EMPTY_TO_AVOID_SED}yz" provider/cmd/pulumi-tfgen-${NAME}
	mv "provider/cmd/pulumi-resource-x${EMPTY_TO_AVOID_SED}yz" provider/cmd/pulumi-resource-${NAME}

	if [[ "${OS}" != "Darwin" ]]; then \
		find ./ ! -path './.git/*' -type f -exec sed -i 's,github.com/pulumi/pulumi-[x]yz,${REPOSITORY},g' {} \; &> /dev/null; \
		find ./ ! -path './.git/*' -type f -exec sed -i 's/[x]yz/${NAME}/g' {} \; &> /dev/null; \
		find ./ ! -path './.git/*' -type f -exec sed -i 's/[a]bc/${ORG}/g' {} \; &> /dev/null; \
	fi

	# In MacOS the -i parameter needs an empty string to execute in place.
	if [[ "${OS}" == "Darwin" ]]; then \
		find ./ ! -path './.git/*' -type f -exec sed -i '' 's,github.com/pulumi/pulumi-[x]yz,${REPOSITORY},g' {} \; &> /dev/null; \
		find ./ ! -path './.git/*' -type f -exec sed -i '' 's/[x]yz/${NAME}/g' {} \; &> /dev/null; \
		find ./ ! -path './.git/*' -type f -exec sed -i '' 's/[a]bc/${ORG}/g' {} \; &> /dev/null; \
	fi

.PHONY: development provider build_sdks build_nodejs build_dotnet build_go build_python cleanup

development:: install_plugins provider lint_provider build_sdks install_sdks cleanup # Build the provider & SDKs for a development environment

# Required for the codegen action that runs in pulumi/pulumi and pulumi/pulumi-terraform-bridge
build:: install_plugins provider build_sdks install_sdks
only_build:: build

tfgen:: install_plugins
	cd provider && go build -o $(WORKING_DIR)/bin/${TFGEN} -ldflags "-X ${PROJECT}/${VERSION_PATH}=${VERSION}" ${PROJECT}/${PROVIDER_PATH}/cmd/${TFGEN}
	$(WORKING_DIR)/bin/${TFGEN} schema --out provider/cmd/${PROVIDER}

provider:: tfgen install_plugins # build the provider binary
	(cd provider && go build -o $(WORKING_DIR)/bin/${PROVIDER} -ldflags "-X ${PROJECT}/${VERSION_PATH}=${VERSION}" ${PROJECT}/${PROVIDER_PATH}/cmd/${PROVIDER})

build_sdks:: install_plugins provider build_nodejs build_python build_go build_dotnet # build all the sdks

build_nodejs:: VERSION := $(shell pulumictl get version --language javascript)
build_nodejs:: install_plugins tfgen # build the node sdk
	$(WORKING_DIR)/bin/$(TFGEN) nodejs --overlays provider/overlays/nodejs --out sdk/nodejs/
	cd sdk/nodejs/ && \
        yarn install && \
        yarn run tsc && \
        cp ../../README.md ../../LICENSE package.json yarn.lock ./bin/ && \
		sed -i.bak -e "s/\$${VERSION}/$(VERSION)/g" ./bin/package.json

build_python:: PYPI_VERSION := $(shell pulumictl get version --language python)
build_python:: install_plugins tfgen # build the python sdk
	$(WORKING_DIR)/bin/$(TFGEN) python --overlays provider/overlays/python --out sdk/python/
	cd sdk/python/ && \
        cp ../../README.md . && \
        python3 setup.py clean --all 2>/dev/null && \
        rm -rf ./bin/ ../python.bin/ && cp -R . ../python.bin && mv ../python.bin ./bin && \
        sed -i.bak -e 's/^VERSION = .*/VERSION = "$(PYPI_VERSION)"/g' -e 's/^PLUGIN_VERSION = .*/PLUGIN_VERSION = "$(VERSION)"/g' ./bin/setup.py && \
        rm ./bin/setup.py.bak && \
        cd ./bin && python3 setup.py build sdist

build_dotnet:: DOTNET_VERSION := $(shell pulumictl get version --language dotnet)
build_dotnet:: install_plugins tfgen # build the dotnet sdk
	pulumictl get version --language dotnet
	$(WORKING_DIR)/bin/$(TFGEN) dotnet --overlays provider/overlays/dotnet --out sdk/dotnet/
	cd sdk/dotnet/ && \
		echo "${DOTNET_VERSION}" >version.txt && \
        dotnet build /p:Version=${DOTNET_VERSION}

build_go:: install_plugins tfgen # build the go sdk
	$(WORKING_DIR)/bin/$(TFGEN) go --overlays provider/overlays/go --out sdk/go/

lint_provider:: provider # lint the provider code
	cd provider && golangci-lint run -c ../.golangci.yml

cleanup:: # cleans up the temporary directory
	rm -r $(WORKING_DIR)/bin
	rm -f provider/cmd/${PROVIDER}/schema.go

help::
	@grep '^[^.#]\+:\s\+.*#' Makefile | \
		sed "s/\(.\+\):\s*\(.*\) #\s*\(.*\)/`printf "\033[93m"`\1`printf "\033[0m"`	\3 [\2]/" | \
		expand -t20

clean::
	rm -rf sdk/{dotnet,nodejs,go,python}

install_plugins::
	[ -x $(shell which pulumi) ] || curl -fsSL https://get.pulumi.com | sh
	pulumi plugin install resource random 4.3.1

install_dotnet_sdk::
	mkdir -p $(WORKING_DIR)/nuget
	find . -name '*.nupkg' -print -exec cp -p {} ${WORKING_DIR}/nuget \;

install_python_sdk::

install_go_sdk::

install_nodejs_sdk::
	yarn link --cwd $(WORKING_DIR)/sdk/nodejs/bin

install_sdks:: install_dotnet_sdk install_python_sdk install_nodejs_sdk

test::
	cd examples && go test -v -tags=all -parallel ${TESTPARALLELISM} -timeout 2h

build_package::
	tar -czvf ${PACKAGE_PATH} -C ${PWD}/bin ${PROVIDER}


publish_provider::
	@echo "Upload to repo: $$PROVIDER_REPO"
	@curl --fail --progress-bar  -u "$$STORAGE_USER":"$$STORAGE_PASSWORD" \
		"$$PROVIDER_REPO" --upload-file "${PACKAGE_PATH}" \
		| cat

publish_sdk_nodejs::
	@echo "Upload to repo: $$NPM_REPO"
	@cd sdk/nodejs/bin && \
	rm -rf .npmrc && \
	NPM_AUTH=$$(echo -n "$$NPM_USER:$$NPM_PASSWORD" | base64) && \
	NPM_AUTH_FIELD=$$(echo $NPM_REPO | sed 's/^https\?://') && \
	npm config --location project set registry="$NPM_REPO" && \
	npm config --location project set "$$NPM_AUTH_FIELD:_auth=$$NPM_AUTH" && \
	npm --location project publish && \
	rm -rf .npmrc

# check git state is clean, everything commited, no untracked files
exit_on_dirty_git::
ifneq ($(shell git status --porcelain=v1 2>/dev/null | wc -l),0)
	@echo "Repository is not clean! Commit all your changes and resolve untracked files!"
	@exit 1
endif
	@echo "All clean."


check_git_tag::
	@if [ -z "$(git_tag)" ]; then \
		echo "git_tag is empty! Usage example: make git_tag=v0.14.0 set_version_tag"; \
		exit 1; \
	fi;
	@if [[ "$(git_tag)" =~ $(SEMVER_REGEX) ]]; then \
		echo "git_tag is valid: $(git_tag)"; \
	else \
		echo "git_tag '$(git_tag)' is not valid. Valid example: v0.14.3"; \
		exit 1; \
	fi

set_version_tag:: exit_on_dirty_git check_git_tag
	@echo "Version tag for this commit will be: ${git_tag}"
	@echo "Delete version tag if it exsists"
	-git push origin :refs/tags/${git_tag}
	-git tag -d ${git_tag}
	@echo "Set tag."
	git tag -a ${git_tag} -m ""
	git push origin refs/tags/${git_tag}