FROM mcr.microsoft.com/dotnet/core/aspnet:5.0.0-preview.3-alpine3.11 AS base
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false \
    LC_ALL=en_US.UTF-8 \
    LANG=en_US.UTF-8
# Install cultures (same approach as Alpine SDK image)
RUN apk add --no-cache icu icu-libs
RUN apk --no-cache add curl
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:5.0.100-preview.3-alpine3.11 AS build
# Disable the invariant mode (set in base image)
# https://www.abhith.net/blog/docker-sql-error-on-aspnet-core-alpine/
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false \
    LC_ALL=en_US.UTF-8 \
    LANG=en_US.UTF-8
# Install cultures (same approach as Alpine SDK image)
RUN apk add --no-cache icu icu-libs
RUN apk --no-cache add curl


WORKDIR /src
COPY ["WebUI.csproj", "./"]
RUN dotnet restore "WebUI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "WebUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebUI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app/logs

WORKDIR /app

COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5000

ENTRYPOINT ["dotnet", "WebUI.dll"]
