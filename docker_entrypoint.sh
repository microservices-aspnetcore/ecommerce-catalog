#!/bin/bash
cd /pipeline/source/app/publish
echo "Starting eCommerce Catalog Service"

dotnet StatlerWaldorfCorp.EcommerceCatalog.dll --server.urls=http://0.0.0.0:${PORT-"8080"}