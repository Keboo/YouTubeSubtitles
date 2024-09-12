# Notes
These commands should be run from the directory ABOVE this project's directory.

Commands to build and push the docker image to Azure Container Registry:
```cli
az login
az acr login --name keboobot
docker build . -f .\KebooBot.Lib\Dockerfile -t keboobot.azurecr.io/bot/keboobot:<VERSION> --push
```

Config is stored in appsettings.Production.json/appsettings.Development.json contains the same data without the keys.