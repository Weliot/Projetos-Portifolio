FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/TravelApp.Web.Host/TravelApp.Web.Host.csproj", "src/TravelApp.Web.Host/"]
COPY ["src/TravelApp.Web.Core/TravelApp.Web.Core.csproj", "src/TravelApp.Web.Core/"]
COPY ["src/TravelApp.Application/TravelApp.Application.csproj", "src/TravelApp.Application/"]
COPY ["src/TravelApp.Core/TravelApp.Core.csproj", "src/TravelApp.Core/"]
COPY ["src/TravelApp.EntityFrameworkCore/TravelApp.EntityFrameworkCore.csproj", "src/TravelApp.EntityFrameworkCore/"]
WORKDIR "/src/src/TravelApp.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TravelApp.Web.Host", "src/TravelApp.Web.Host"]
COPY ["src/TravelApp.Web.Core", "src/TravelApp.Web.Core"]
COPY ["src/TravelApp.Application", "src/TravelApp.Application"]
COPY ["src/TravelApp.Core", "src/TravelApp.Core"]
COPY ["src/TravelApp.EntityFrameworkCore", "src/TravelApp.EntityFrameworkCore"]
WORKDIR "/src/src/TravelApp.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TravelApp.Web.Host.dll"]
