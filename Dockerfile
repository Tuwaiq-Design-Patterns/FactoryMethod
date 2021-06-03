FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Factory/Factory.csproj", "Factory/"]
RUN dotnet restore "Factory/Factory.csproj"
COPY . .
WORKDIR "/src/Factory"
RUN dotnet build "Factory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Factory.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Factory.dll"]
