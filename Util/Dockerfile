FROM mcr.microsoft.com/mssql/server:2019-latest

USER root

COPY Scripts scripts
COPY Scripts/import-data.sh import-data.sh
COPY Scripts/entrypoint.sh entrypoint.sh

RUN chmod 755 /scripts/*
RUN chmod +x entrypoint.sh
RUN chmod +x import-data.sh

ENTRYPOINT ./entrypoint.sh