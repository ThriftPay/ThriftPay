#!/bin/bash

# publish
supervisorctl stop api.thriftpay.co
cd src/ThriftPay.Core
dotnet restore
cd ../ThriftPay.API
dotnet restore
dotnet publish -r coreclr -o /var/www/aspnet/ThriftPay.API
cd ../../
sudo chown -R www-data:www-data /var/www/aspnet/ThriftPay.API
supervisorctl start api.thriftpay.co