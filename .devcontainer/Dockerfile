ARG VERSION
ARG REMOTE_USER
ARG REMOTE_UID
ARG REMOTE_GID
FROM docker.io/pulumi/pulumi-provider-build-environment:${VERSION}

RUN addgroup --gid ${REMOTE_GID} ${REMOTE_USER} && \
    adduser --disabled-password --uid ${REMOTE_UID} --gid ${REMOTE_GID} ${REMOTE_USER}

ENV HOME /home/${REMOTE_USER}

USER ${REMOTE_USER}