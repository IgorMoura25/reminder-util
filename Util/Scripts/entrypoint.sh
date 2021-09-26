#!/bin/bash

echo "RUNNING SQL SERVER IN BACKGROUND"
./import-data.sh & /opt/mssql/bin/sqlservr