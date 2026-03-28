#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/e2b-dev/E2B/main/spec/openapi.yml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://raw.githubusercontent.com/e2b-dev/E2B/main/spec/openapi.yml -o openapi.yaml

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace E2B \
  --clientClassName E2BClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
