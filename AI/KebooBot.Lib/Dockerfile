ARG BUILD_IMAGE_TAG="8.0-jammy"

ARG PLATFORM=$BUILDPLATFORM

FROM --platform=$PLATFORM mcr.microsoft.com/dotnet/sdk:$BUILD_IMAGE_TAG AS build

ARG BUILD_CONFIGURATION=Release

COPY . /src/
WORKDIR "/src/KebooBot.Lib"
RUN dotnet build KebooBot.Lib.csproj -c $BUILD_CONFIGURATION -o /app/build /p:RepoRoot=/src/
RUN dotnet publish "./KebooBot.Lib.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:RepoRoot=/src/

ARG PLATFORM

FROM --platform=$PLATFORM kernelmemory/service:latest AS base

WORKDIR /app
COPY --from=build --chown=km:km --chmod=0550 /app/publish .
COPY --from=build --chown=km:km --chmod=0550 /src/KebooBot.Lib/appsettings.Production.json .

# Define executable
ENTRYPOINT ["dotnet", "Microsoft.KernelMemory.ServiceAssembly.dll"]