#!/usr/bin/env bash
set -euo pipefail
readonly openapi_url="https://raw.githubusercontent.com/e2b-dev/E2B/main/spec/openapi.yml"
dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.yaml

# E2B spec uses apiKey in X-API-Key header. Convert to http/bearer for AutoSDK constructor generation.
# Add top-level security array.
yq -i '
  .components.securitySchemes.ApiKeyAuth = {"type": "http", "scheme": "bearer"} |
  .security = [{"ApiKeyAuth": []}]
' openapi.yaml

autosdk generate openapi.yaml \
  --namespace E2B \
  --clientClassName E2BClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
