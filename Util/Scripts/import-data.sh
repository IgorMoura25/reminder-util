#!/bin/sh

echo "SLEEPING 15 SECONDS"
sleep 15s

echo "EXECUTING SCRIPTS"
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Password1!" -i ./scripts/setup.sql