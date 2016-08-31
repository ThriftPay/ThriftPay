#!/bin/bash

# publish
supervisorctl stop account.thriftpay.co
cd src/ThriftPay.Core
dotnet restore
cd ../ThriftPay.Account
dotnet restore
dotnet publish -r coreclr -o /var/www/aspnet/ThriftPay.Account
cd ../../
sudo chown -R www-data:www-data /var/www/aspnet/ThriftPay.Account
supervisorctl start account.thriftpay.co