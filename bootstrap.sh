#!/usr/bin/env bash

apt-get update
apt-get install -y mono-runtime
apt-get install -y mono-fastcgi-server4
apt-get install -y git
apt-get install -y nginx