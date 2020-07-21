FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build

WORKDIR /K8sApi
COPY K8s.Api.csproj build/
RUN dotnet restore build/K8s.Api.csproj

COPY . build
RUN dotnet publish build/K8s.Api.csproj -c RELEASE -o publish


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /K8sApi/app
COPY --from=build /K8sApi/publish .
ENTRYPOINT ["dotnet","K8s.Api.dll"]

