#!/bin/bash

mkdir ./.devcontainer/logs/ -p
nohup bash -c 'octant --disable-origin-check --disable-open-browser &' > ./.devcontainer/logs/octant.log
