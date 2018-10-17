FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ApiGateWays/ApiGateWays.csproj ApiGateWays/
RUN dotnet restore ApiGateWays/ApiGateWays.csproj
COPY . .
WORKDIR /src/ApiGateWays
RUN dotnet build ApiGateWays.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ApiGateWays.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ApiGateWays.dll"]
