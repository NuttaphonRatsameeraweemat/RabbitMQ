FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Prototype.RabiitMq/Prototype.RabiitMq.csproj Prototype.RabiitMq/
COPY Prototype.RabbitMq.EventBus/Prototype.RabbitMq.EventBus.csproj Prototype.RabbitMq.EventBus/
COPY Prototype.RabbitMq.EventBusRabbitMQ/Prototype.RabbitMq.EventBusRabbitMQ.csproj Prototype.RabbitMq.EventBusRabbitMQ/
RUN dotnet restore Prototype.RabiitMq/Prototype.RabiitMq.csproj
COPY . .
WORKDIR /src/Prototype.RabiitMq
RUN dotnet build Prototype.RabiitMq.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Prototype.RabiitMq.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Prototype.RabiitMq.dll"]
