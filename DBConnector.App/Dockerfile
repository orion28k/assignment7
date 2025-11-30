# Multi-stage build for DBConnector.App console REPL targeting .NET 9
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY reference.sln ./
COPY DBConnector/ DBConnector/
COPY DBConnector.App/ DBConnector.App/
WORKDIR /src/DBConnector.App
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish --no-self-contained

FROM mcr.microsoft.com/dotnet/runtime:9.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENV DOTNET_EnableDiagnostics=0
ENTRYPOINT ["dotnet", "DBConnector.App.dll"]