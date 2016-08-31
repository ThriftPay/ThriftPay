#!/bin/bash

# publish
supervisorctl stop account.thriftpay.co
dotnet publish -r coreclr -o /var/www/aspnet/ThriftPay.Account
supervisorctl start account.thriftpay.co