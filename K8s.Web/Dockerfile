FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build

WORKDIR /K8sWeb
COPY K8s.Web.csproj build/
RUN dotnet restore build/K8s.Web.csproj

COPY . build
RUN dotnet publish build/K8s.Web.csproj -c RELEASE -o publish


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /K8sWeb/app
COPY --from=build /K8sWeb/publish .
ENTRYPOINT ["dotnet","K8s.Web.dll"]

