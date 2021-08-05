#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["domain-info.api/domain-info.api.csproj", "domain-info.api/"]
RUN dotnet restore "domain-info.api/domain-info.api.csproj"
COPY . .
WORKDIR "/src/domain-info.api"
RUN dotnet build "domain-info.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "domain-info.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "domain-info.api.dll"]