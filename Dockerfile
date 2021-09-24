FROM mcr.microsoft.com/dotnet/sdk:3.1
COPY ./Util Util/
COPY ./UtilTest UtilTest/
WORKDIR /Util