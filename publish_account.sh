#!/bin/bash

# publish
cd src/ThriftPay.Account
supervisorctl stop account.thriftpay.co
dotnet restore
dotnet publish -r coreclr -o /var/www/aspnet/ThriftPay.Account
supervisorctl start account.thriftpay.co
cd ../../