#!/bin/bash

# publish
supervisorctl stop api.thriftpay.co
cd src/ThriftPay.API
cd src/ThriftPay.Core
dotnet restore
cd ../ThriftPay.API
dotnet restore
dotnet publish -r coreclr -o /var/www/aspnet/ThriftPay.API
cd ../../
supervisorctl start api.thriftpay.co