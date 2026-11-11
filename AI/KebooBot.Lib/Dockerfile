ARG BUILD_IMAGE_TAG="11.0"
ARG RUNTIME_IMAGE_TAG="11.0-alpine"

ARG PLATFORM=$BUILDPLATFORM

FROM --platform=$PLATFORM mcr.microsoft.com/dotnet/sdk:$BUILD_IMAGE_TAG AS build

ARG BUILD_CONFIGURATION=Release

COPY . /src/
WORKDIR "/src/AI/KebooBot.Lib"
RUN dotnet build KebooBot.Lib.csproj -c $BUILD_CONFIGURATION -o /app/build /p:RepoRoot=/src/
RUN dotnet publish "./KebooBot.Lib.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:RepoRoot=/src/

ARG PLATFORM

FROM --platform=$PLATFORM kernelmemory/service:latest AS kernelmemory

FROM --platform=$PLATFORM mcr.microsoft.com/dotnet/aspnet:$RUNTIME_IMAGE_TAG AS base

WORKDIR /app
RUN addgroup -S km && adduser -S -D -h /app -G km km && chown km:km /app && apk add --no-cache icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false \
    ASPNETCORE_ENVIRONMENT=Production \
    ASPNETCORE_URLS=http://+:9001 \
    ASPNETCORE_HTTP_PORTS=9001
# The upstream Kernel Memory host targets .NET 9; run it with the .NET 11 extensions.
ENV DOTNET_ROLL_FORWARD=Major
COPY --from=kernelmemory --chown=km:km --chmod=0550 /app/ .
COPY --from=build --chown=km:km --chmod=0550 /app/publish .
COPY --from=build --chown=km:km --chmod=0550 /src/AI/KebooBot.Lib/appsettings.Production.json .

USER km
EXPOSE 9001

# Define executable
ENTRYPOINT ["dotnet", "Microsoft.KernelMemory.ServiceAssembly.dll"]