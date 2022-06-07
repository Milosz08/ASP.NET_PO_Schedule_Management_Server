﻿FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

EXPOSE 80
EXPOSE 443

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "asp-net-po-schedule-management-server.dll"]