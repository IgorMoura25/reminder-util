
#!/bin/bash

echo "RUNNING SQL SERVER IN BACKGROUND"
./migrate-version.sh & /opt/mssql/bin/sqlservr