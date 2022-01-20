FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BalleVinyls/BalleVinyls.csproj", "BalleVinyls/"]
RUN dotnet restore "BalleVinyls/BalleVinyls.csproj"
COPY . .
WORKDIR "/src/BalleVinyls"
RUN dotnet build "BalleVinyls.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BalleVinyls.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BalleVinyls.dll"]
