#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ChartsModule.API/ChartsModule.API.csproj", "ChartsModule.API/"]
RUN dotnet restore "ChartsModule.API/ChartsModule.API.csproj"
COPY . .
WORKDIR "/src/ChartsModule.API"
RUN dotnet build "ChartsModule.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ChartsModule.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ChartsModule.API.dll"]