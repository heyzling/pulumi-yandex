ARG PULUMI_DEV_IMAGE_VERSION=3.130.0
FROM docker.io/pulumi/pulumi-provider-build-environment:${PULUMI_DEV_IMAGE_VERSION}

ARG USERNAME
ARG USERID
ARG GROUPID

RUN groupadd -g ${GROUPID} ${USERNAME} \
    && useradd -u ${USERID} -g ${GROUPID} ${USERNAME}

# All tools in dev container looking to /root
# The fastest way to fix this is make /root acessible by user.
# Very wrong for real systems, but its acceptable hack for temp container (I suppose :P)
RUN chown -R "${USERID}:${GROUPID}" /root

WORKDIR /root

USER ${USERID}