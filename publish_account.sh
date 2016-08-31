#!/bin/bash

# publish
supervisorctl stop account.thriftpay.co
cd src/ThriftPay.Core
dotnet restore
cd ../ThriftPay.Account
dotnet restore
dotnet publish -r coreclr -o /var/www/aspnet/ThriftPay.Account
cd ../../
supervisorctl start account.thriftpay.co