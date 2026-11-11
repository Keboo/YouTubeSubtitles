# Notes
These commands should be run from the repository root. The Docker build requires
the central NuGet package configuration at the root and uses .NET 11 SDK and
ASP.NET Core runtime images. The upstream Kernel Memory host is copied into the
runtime image and configured to roll forward from .NET 9 to .NET 11.

Commands to build and push the docker image to Azure Container Registry:
```cli
az login
az acr login --name keboobot
docker build . -f .\AI\KebooBot.Lib\Dockerfile -t keboobot.azurecr.io/bot/keboobot:<VERSION> --push
```

Provide `AI\KebooBot.Lib\appsettings.Production.json` locally before building;
do not commit credentials. `appsettings.Development.json` contains the same
configuration without the keys.