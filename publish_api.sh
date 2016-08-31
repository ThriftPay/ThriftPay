#!/bin/bash

# publish
cd src/ThriftPay.API
supervisorctl stop api.thriftpay.co
dotnet publish -r coreclr -o /var/www/aspnet/ThriftPay.API
supervisorctl start api.thriftpay.co
cd ../../