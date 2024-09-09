# Хроники разработки бриджа


- [Хроники разработки бриджа](#хроники-разработки-бриджа)
   - [1. Установить все пререквизиты](#1-установить-все-пререквизиты)
      - [Готовый образ](#готовый-образ)
      - [Devcontainers](#devcontainers)
      - [Ручная установка (Linux / Redhat-based)](#ручная-установка-linux--redhat-based)
   - [2. Создать репозиторий](#2-создать-репозиторий)
   - [3. Настроить репозиторий на сборку Yandex Cloud провайдера](#3-настроить-репозиторий-на-сборку-yandex-cloud-провайдера)
   - [4. Тестирование](#4-тестирование)
      - [Ручной запуск примеров](#ручной-запуск-примеров)
      - [Автоматическое end-to-end тестирование](#автоматическое-end-to-end-тестирование)
   - [5. Публикация](#5-публикация)
      - [Теория](#теория)
      - [Как считается версия](#как-считается-версия)
      - [Таргеты публикации в Makefile](#таргеты-публикации-в-makefile)
   - [Как собрать, если все подготовлено](#как-собрать-если-все-подготовлено)
   - [Зоны роста](#зоны-роста)
   - [Альтернативные способы сборки бриджа](#альтернативные-способы-сборки-бриджа)


Здесь описана хроника того, как можно сделать Terraform-Pulumi бридж для провайдера Yandex Cloud используя специальный репозиторий-шаблон [pulumi-tf-provider-boilerplate](https://github.com/pulumi/pulumi-tf-provider-boilerplate)

Оффициальный гайд в этом репозитории довольно абстрактный, содержит много пояснений и ответвлений в сторону. В их инструкции не хватает некоторых деталей и некоторых моментов необходимых именно для Yandex Cloud.

В этом гайде я стремился описать всю последовательность действий, которую проделал чтобы получить рабочий бридж.

В конце добавил "зоны роста" - чего не хватает, чтобы вся это конструкция напоминала продуктивную, а также ссылки на альтернативные возможности собрать бридж.

## 1. Установить все пререквизиты

Я ставил все инстурменты на свою локальную машин (Linux, Fedora 40). Но в процессе подготовке этого гайда заинтересовался возможностью использовать официальный образ и немного потыкал его.

### Готовый образ

> **DISCLAIMER** В образе все работает из-под root.
> Найденный контейнер сделан таким образом, что его нетривиально перевести на работу из-под рядового пользователя. Все инстурменты которые в нем установлены (git, golang и т.д.) завязаны на работу из-под root и ломаются если использовать non-root пользователя.


```bash
docker run --rm -it \
   -v "$PWD":"/root/$(basename $PWD)" \
   -w "/root/$(basename $PWD)" \
   docker.io/pulumi/pulumi-provider-build-environment:3.130.0 \
   bash

# Внутри контейнера нужно сразу чинить git, чтобы он
# чтобы оне не ругался на незнакомых владельцев у файлов/папок
git config --global --add safe.directory /root/pulumi-yandex

# после выхода из контейнера, надо поправить владельцев новых файлов
sudo chmod -r $USER:$USER
```

### Devcontainers

> **DISCLAIMER Завести не получилось.**

1. Оригинальный Dockerfile не собирается нормально. В Ubuntu больше нет в репозиториях dotnet-sdk.
1. Непонятно как завести devcontainer в WSL так, чтобы он раобтал не из-под рута. При правке образа (любой) и попытке запуска devcontainer через build а не image, падает с неинфомративной ошибкой.

[VsCode Docs. Install Devcontainers.](https://code.visualstudio.com/docs/devcontainers/containers#_installation)

### Ручная установка (Linux / Redhat-based)

**DISCLAIMER** Это мой личный рабочий сетап. Отлажено на Fedora 40.

```bash
### pulumi
curl -fsSL https://get.pulumi.com | sh

### pulumictl (Это не обычный pulumi CLI. Это отдельный бинарник pulumictl для разработки Pulumi и его провайдеров)
PULUMICTL_VERSION="0.0.46"
cd /tmp
curl --progress-bar -OJ -L https://github.com/pulumi/pulumictl/releases/download/v${PULUMICTL_VERSION}/pulumictl-v${PULUMICTL_VERSION}-linux-amd64.tar.gz
tar -xzf pulumictl-v${PULUMICTL_VERSION}-linux-amd64.tar.gz
chmod +x pulumictl
mv ./pulumictl $HOME/.pulumi/bin/
pulumictl version

### NodeJS
# https://nodejs.org/en/download/package-manager/
# install via fnm (Fast Node Manager)
curl -fsSL https://fnm.vercel.app/install | bash
fnm use --install-if-missing 20
node -v
npm -v

# yarn
npm install --global typescript
npm install --global yarn

### make
sudo dnf install -y make

### golang
# Source codenoid: https://gist.github.com/codenoid/4806365032bb4ed62f381d8a76ddb8e6
printf "Checking latest Go version...\n";
# LATEST_GO_VERSION="$(curl --silent https://go.dev/VERSION?m=text | head -n 1)";
# версия golang матчится с версией golangci-lint (см. далее)
# при несовместимости версий начинается утечка памяти (у меня повесило всю WSL намертво =))
LATEST_GO_VERSION=go1.22.5
LATEST_GO_DOWNLOAD_URL="https://go.dev/dl/${LATEST_GO_VERSION}.linux-amd64.tar.gz"
cd $HOME
curl -OJ -L --progress-bar $LATEST_GO_DOWNLOAD_URL
tar -xf ${LATEST_GO_VERSION}.linux-amd64.tar.gz
set -x
export GOROOT="$HOME/go"
export GOPATH="$HOME/go/packages"
export PATH=$PATH:$GOROOT/bin:$GOPATH/bin
set +x
printf '⚠️  ADD (OR REPLACE) THIS LINE BELOW TO YOUR ~/.bashrc  ⚠️

export GOROOT="$HOME/go"
export GOPATH="$HOME/go/packages"
export PATH=$PATH:$GOROOT/bin:$GOPATH/bin
\n'
go version

#golangci-linter
GolangCILintVersion="1.59.1"
curl -sSfL https://raw.githubusercontent.com/golangci/golangci-lint/master/install.sh | sh -s -- -b $(go env GOPATH)/bin v$GolangCILintVersion

### .NET
# Следующая правка важна только для Fedora И если у вас есть репозитории Microsoft.
# Нужно понизить приоритет репозиториев Microsoft,
# чтобы .NET SDK устанавливались из Fedora-репозиториев.
# Ирония, но в Microsoft репозиториях - сломаный пакет =)
sudo echo 'priority=199' | sudo tee -a /etc/yum.repos.d/microsoft.repo
# установить
sudo dnf install -y dotnet-sdk-6.0
```

## 2. Создать репозиторий

1. Склонировать оригинальный репозиторий с boilerplate-ом: `git clone https://github.com/pulumi/pulumi-tf-provider-boilerplate.git pulumi-yandex`

1. Создать новый репозиторий в GitHub и назвать его pulumi-yandex
   Название рекомендуется конвенцией Pulumi. Имя такое же как [у архивной копии, которую делали Pulumi](https://github.com/pulumi/pulumi-yandex)

1. Поменять `remote`: `git remote set-url origin git@github.com:heyzling/pulumi-yandex.git`

1. Сделать init-коммит: `git push --set-upstream`

1. Создать фича-ветку для дальнейшей работы
   ```bash
   git switch -c feature/init-bridge-yandex-cloud-provider
   git push --set-upstream origin feature/init-bridge-yandex-cloud-provider
   ```

## 3. Настроить репозиторий на сборку Yandex Cloud провайдера

Большинство из шагов ниже сопровождены коммитом в репозитории. Из описания коммита можно понять к какому шагу он относится.

1. Сделать подготовку. В `REPOSITORY` нужно подставить свой репозиторий в github без `https://` и с `.git` на конце. 
   
   ```bash
   make prepare NAME=yandex REPOSITORY=github.com/heyzling/pulumi-yandex.git ORG=yandex
   ```

   > Команда переименует в репозитории все упоминания плейсхолдера имени провайдера на `yandex`. Будут переименованы папки и изменены некоторые файлы. 
   > Важно оставить NAME=yandex и ORG=yandex, потому что они используются в том числе в переименовании импортов. Другие имена - сломают ссылки на зависимости.

1. Поправить импорт и метадату для сборки провайдера в `provider/resources.go`
   1. Заменить болванку пакета собираемого провайдера на оригинальный провайдер yadex-cloud для Terraform: 
      ```bash
         sed 's/github.com\/iwahbe\/terraform-provider-yandex\/provider/github.com\/yandex-cloud\/terraform-provider-yandex\/yandex/' -i ./provider/resources.go
      ```

   1. Поправить некоторые свойства в конструкторе бриджа. Найдо найти функцию `Provider()` и в ней создание объекта `prov := tfbridge.ProviderInfo`. Нужно поправить в нем следующие свойства:
      1. `P`: `shimv2.NewProvider(yandex.NewSDKProvider())`.
         Здесь использован именно тот метод, который используется в Terraform провайдере Yandex Cloud.
      1. `Publisher`: `heyzling`.
         Кто публикует? Так как это неофициальный бридж, то я поставил свой ник.
      1. `PluginDownloadURL`: `https://github.com/heyzling/pulumi-yandex/releases/`.
         Так как публикации в Pulumi Registry не будет, это единственная возможность, сказать Pulumi где брать бинарную часть провайдера. Эта ссылка далее будет зашиваться в метадату пакетов SDK. Pulumi будет видеть ее и выкачивать плагин во время `pulumi pre|up`
      1. `GitHubOrg`: `yandex-cloud`
         Это Организация в GitHub в которой при сборке будет искаться провайдер для терраформа и его документация. По умолчанию он лезет в организацию `terraform-public`, но Yandex Cloud свой провайдер держит у себя.

1. Скачать зависимости.
   
   ```bash
      # Прогнать golang-fmt, иначе будет ругаться при сборке.
      gofmt -s -w provider/cmd/pulumi-tfgen-yandex/main.go
      gofmt -s -w provider/cmd/pulumi-resource-yandex/main.go

      # Скачать все зависимости для сборки бирджа провайдера
      cd provider
      go mod tidy 
      cd -
   ```
   
   Если `go mod tidy` не скачивает зависимости, а просто сразу выводит пустоту - то что-то не так с кодом. сделайте `go build` для проверки синтаксиса и исправьте ошибки.

   Иногда могут возникнуть ошибки вида `local error: tls: bad record MAC`. Это либо сетевые ошибки, либо когда `make prepare` заменяет в go.sum файле в хеше некоторых пакето `xyz` или `abc` на `yandex` =). Решение: просто выполнить `go mod` еще раз 

1. Сгенерировать JSON схему ресурсов из Terraform провайдера: 

   ```bash
      make tfgen
   ```
   
   Если идут **Warning-сообщения**, но написано что найдено N ресурсов и документация для >90% от них - то **это нормально**.

   Пример более-менее нормальной генерации (конец вывода):
   ```text
   Provider:     yandex
   Success rate: 93.53% (853/912)

   Converted 91.45% of csharp examples (139/152)
   Converted 91.45% of go examples (139/152)
   Converted 98.03% of java examples (149/152)
   Converted 91.45% of python examples (139/152)
   Converted 91.45% of typescript examples (139/152)
   Converted 97.37% of yaml examples (148/152)

   General metrics:
         120 total resources containing 2110 total inputs.
         87 total functions.
         91 entities are missing docs entirely because they could not be found in the upstream provider.

   Argument metrics:
         1868 argument descriptions were parsed from the upstream docs
         13 top-level input property descriptions came from an upstream attribute (as opposed to an argument). Nested arguments are not included in this count.
         7 arguments contained an <elided> reference and had their descriptions dropped.
         2 nested arguments contained an <elided> reference and had their descriptions dropped.
         379 of 2110 resource inputs (17.96%) are missing descriptions in the schema
   ```

1. Собрать бинарник провайдера для Pulumi: `make provider`

1. Поправить конфиг линтера и прогнать его:
   ```bash
      # поправить конфиг линтера. В оригинальном репозитории он устарел и вываливает предупреждения
      cat > .golangci.yml << EOF
      linters:
      enable:
         - gosimple
         - staticcheck
         - errcheck
         - goconst
         - gofmt
         - gosec
         - govet
         - ineffassign
         - lll
         - misspell
         - nakedret
         - revive
         - unconvert
         - unused
      enable-all: false
      run:
      timeout: 20m
      issues:
      exclude-files:
         - schema.go
         - pulumiManifest.go

      EOF

      # прогнать линтер. Никаких ошибок быть не должно. Но если вдруг есть - нужно исправить.
      make lint_provider
   ```

1. Собрать все доступные SDK. 
   ```bash
      # собрать
      make build_nodejs build_python build_go build_dotnet

      # Закоммитить в репозиторий.
      # Собранные SDK должны быть в репозитории по рекомендации Pulumi
      git add sdk/**
      git commit -m "build SDKs"
   ```

## 4. Тестирование

### Ручной запуск примеров

В `pulumi/examples` есть примеры. Они же тесты. В данный момент есть только пример для NodeJS/TypeScript.

Ниже пример того, как можно его запустить на собранном провайдере.

```bash
# временно копировать собранный бинарник провайдера в GOPATH
cp bin/pulumi-resource-yandex $GOPATH/bin
# "зарегистрировать" собранное NodeJS SDK в yarn
make install_nodejs_sdk # под капотом это просто: yarn link --cwd $PWD/sdk/nodejs/bin

### подготовить программу-пример
cd examples/ts
npm install
yarn link @pulumi/yandex
# Команда выше под капотом просто делает симлинк из examples/ts/node_modules sdk/nodejs/bin
# Это можно проверить так:
ls -la node_modules/@pulumi/yandex
ls -la ~/.config/yarn/link/\@pulumi/yandex

## Сделать стейт + стек
# так как у нас проект тестовый, стейт можно хранить локально
pulumi login --local
pulumi stack init test

## Аутентификация
# самый простой вариант аутентификации, если у вас настроен yc config profile
export YC_TOKEN="$(yc iam create-token)"
# альтернатива: выписать приватный ключ для SA и положить его в стек
pulumi config set --secret yandex:serviceAccountKeyFile "$(cat "path/to/my/sakey.json")"

## указать облако и папку для ресурсов
# оба ресурса можно создать из кода
# но тогда будут сложности с их удалением после тестов
# в YC папки и облака могут удаляться очень долго
pulumi config set 'yandex:cloudId' '<cloudId>'
pulumi config set 'yandex:folderId' '<folderId>'

## сделать превью изменений. Должно отработать без ошибок.
# Pulumi должен выдать warning-и вроде "warning: using pulumi-resource-yandex from $PATH at /home/myuser/go/packages/bin/pulumi-resource-yandex" значит используется правильный провайдер. Обратите внимание на путь который он указывает. Это как раз путь к бинарнику, который был скопирован выше.
pulumi pre

# поднять ресурсы
pulumi up

# уничтожить ресурсы
pulumi down

# можно убить до конца и весь стек (его конфигурацию и локальный стейт)
pulumi stack rm test
```

### Автоматическое end-to-end тестирование

Автоматизировать все что описано выше можно, используя фреймворк для тестирования, который Pulumi написал на go.

Запуск тестов описан в файлах `examples*.go`.

1. `examples/examples_test.go` - общие методы для тестов. Важный метод здесь - `getBaseOptions`, в котором описываются базовые параметры запуска тестов. Подробнее о параметрах [можно узнать здесь](https://pkg.go.dev/github.com/pulumi/pulumi/pkg/v3/testing/integration#ProgramTest).
1. `examples_nodejs_test.go` - тест для конкретного SDK (в данном случае - NodeJS). Каждый метод `Test*` - это тест. В методе определяются некоторые дополнения к базовым параметрам запуска и определяется собственно папка с Pulumi-программой, которую надо запустить.

Сейчас написан только тест на запуск примеров из папки `examples/ts`. Т.к. для запуска нужно знать облако, папку и ключ аутентификации, то они явно проверяются в коде.

Как запускать
```bash
### Определить переменные
export YC_TOKEN="$(yc iam create-token)"
export YC_CLOUD_ID="your_cloud_id"
export YC_FOLDER_ID="your_folder_id"

# установить зависимости
cd examples
go mod tidy
cd -

# запустить тесты
make test
```

Тесты запустять программу Pulumi. Сделают для нее `preview`, `up`, `export`, `import` и затем `down`.

Если при запуске тестов во время первого `pulumi preivew` у вас возникает ошибка: `* key unmarshal fail: invalid character '/' looking for beginning of value`. То это значит что у вас указан неправильный путь к приватному ключу SA, либо в содержании файла неправильный формат этого ключа.

## 5. Публикация

### Теория

Провайдер состоит из двух частей - плагин и SDK.

Плагин - это бинарник, который собирается командой `make provider` и собирается в файл `bin/pulumi-resource-yandex`. SDK - это код клиентских библиотек для разных языков. Они собираются в папку `sdk` командой `build_sdks`.

Когда конечный пользователь хочет использовать провайдер, то предполагается, что он установит SDK нативным для языка образом (npm install, pip install, go download и т.д.). В метадате каждой SDK записана ссылка, где хранится бинарная часть провайдера. Поэтому когда пользователь сделает `pulumi pre` или `pulumi up`, то Pulumi пойдет по этой ссылке и скачает бинарную часть провайдера оттуда.

> Ссылка откуда брать бинарник прописывается в `provider/resource.go`, в свойстве `PluginDownloadURL`. См. 3ий шаг, касающийся первичной настройки репозитория.

То есть, чтобы опубликовать провайдер нужно опубликовать две его части:
1. Опубликовать SDK в любой нативный репозиторий этого языка. Можно публичный, можно приватный (Nexus, Artifactory, etc.)
1. Опубликовать бинарник в любом объектном хранилище (S3, FTP, GitHub =)). Финальный архив должен быть доступен без аутентификации.

Для скачивания бинарной части Pulumi формирует ссылку такого формата: `${PluginDownloadURL}/pulumi-resource-${PACK}-v${VERSION}-${OS_LOWER}-${ARCH_NAME}.tar.gz`

То есть для публикации бинарной части, нужно собрать матрицу бинарников, запаковать их в архивы и опубликовать в то хранилище, которое указано в `PluginDownloadURL`.

### Как считается версия

При сборке SDK и плагина Pulumi автоматически высчитывает версию.

Конкретно, используется команда `pulumictl get version`.

Алгоритм у нее примерно такой:
1. Если обычный коммит - ставиться версия вроде 0.1.0-alpha+commit_hash
1. Если на коммите стоит тег с семантическим версионированием, то ставится версия из git тега.
1. Если в репозитории есть "not staged" изменения, то к версии добавляется постфикс `+dirty`

Примеры: 
   `v0.0.1-alpha.1722876801+0bda2432.dirty` - нет тега, "грязный коммит".
   `v0.14.0+dirty` - на коммите тег с версий, "грязный коммит".
   `v0.14.0` - стоит тег с версий, нет unstaged изменений

Соответсвенно, чтобы у собранного плагина была хорошая продуктивная версия, то нужно собирать его на чистом коммите с тегом.

### Таргеты публикации в Makefile

В Makefile добавлены некоторые методы для публикации. Методы publish_* могут глючить или вообще не работать, они не отлажены на сторонних инфраструктурах.

1. `build_package` - собрать архив, готовый для публикации в файловое хранилище. У него будет правильное именование - такое, по которому SDK собранное на этом же коммите сможет его найти. 
1.  `publish_provider` - загрузить собранный архив в файловое хранилище используя curl. Метод пойдет только для таких хранилищ, которые поддерживает прямой upload файла (например, Artifactory или Nexus).
1.  `publish_sdk_nodejs` - публикация собранного NodeJS SDK в приватный NPM репозиторий. Возможно, подойдет для публичного NPM.
1.  `set_version_tag` - повесить на текущий коммит тег с версией, если эта версия продуктивная. Упадет с ошибкой, если версия делается на "грязном" коммите или не соовтетсвует "продуктивному" SemVer (то есть, "vX.Y.Z") 

## Как собрать, если все подготовлено

Когда все приготовления описаные в шагах 3-5 уже сделаны, то собрать все с нуля можно так.

```bash
# если сборка продуктивная (то есть коммит чистый и это мастер-бранч)
make git_tag=v0.14.0 set_version_tag

# сборка
make provider
make build_sdks
make build_package

# публикация (не тестировано на публичной инфраструктуре)
export PROVIDER_REPO=""
export STORAGE_USER=""
export STORAGE_PASSWORD=""
export NPM_REPO=""
export NPM_USER=""
export NPM_PASSWORD=""

make publish_provider
make publish_sdk_nodejs

```

## Зоны роста

1. CICD =)
   Другой репозиторий, где настроен Github Actions (но версия провайдера Terraform 0.99.1): [Regrau/pulumi-yandex](https://github.com/Regrau/pulumi-yandex)
1. Публикация.
1. Сборка матрицы бинарников под разные платформе. В оригинальном репозитории есть инстуркции по тому как это включить: [Building the provider locally](https://github.com/pulumi/pulumi-tf-provider-boilerplate?tab=readme-ov-file#building-the-provider-locally)
1. Документация. Я не исследовал пока, как это можно сделать. Единственная текущая документация - это docstrings в SDK.
1. Автоматическая генерация проектов-примеров в `examples`. Возможно, тоже есть способ. Не исследовано.

## Альтернативные способы сборки бриджа

Эти способы не тестированы.

1. Альтернативный способ собрать бридж через специальный шаблонизатор: [tmeckel/pulumi-tf-provider-cookiecutter](https://github.com/tmeckel/pulumi-tf-provider-cookiecutter)

1. Недавно Pulumi реализовали фичу быстрой трансляции Terraform провайдера в Pulumi провайдер. По словам Pulumi плюс - в легкости трансляции. Минус - нет такой гибкости, как в текущих бриджах.
   - [Pulumi Blog. Introducing: Support For Using Any Terraform Provider with Pulumi](https://www.pulumi.com/blog/any-terraform-provider/)
   - [Анонс этой фичи в Slack (с ответом на вопросы)](https://app.slack.com/client/T85C88L30/CB36DSVSA)

