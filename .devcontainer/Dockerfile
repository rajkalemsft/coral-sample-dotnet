# See here for image contents: https://github.com/microsoft/vscode-dev-containers/tree/v0.192.0/containers/codespaces-linux/.devcontainer/base.Dockerfile

FROM mcr.microsoft.com/vscode/devcontainers/universal:1-focal

# ** [Optional] Uncomment this section to install additional packages. **
USER root

RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends python3.8-venv

RUN RELEASE=$(curl https://api.github.com/repos/k3d-io/k3d/releases/latest | jq -r .tag_name) \
  && curl -L "https://github.com/k3d-io/k3d/releases/download/${RELEASE}/k3d-linux-amd64" -o /usr/local/bin/k3d \
  && chmod +x /usr/local/bin/k3d

# Port forwarding in latest release is broken, locking version to 0.24.0 until resolved (https://github.com/vmware-tanzu/octant/issues/3057)
RUN RELEASE=$(curl https://api.github.com/repos/vmware-tanzu/octant/releases/latest | jq -r .tag_name[1:]) \
  && RELEASE_FIX='0.24.0' \
  && curl -LO "https://github.com/vmware-tanzu/octant/releases/download/v${RELEASE_FIX}/octant_${RELEASE_FIX}_Linux-64bit.tar.gz" \
  && tar xvf "octant_${RELEASE_FIX}_Linux-64bit.tar.gz" \
  && mv "./octant_${RELEASE_FIX}_Linux-64bit/octant" /usr/local/bin/octant

USER codespace
