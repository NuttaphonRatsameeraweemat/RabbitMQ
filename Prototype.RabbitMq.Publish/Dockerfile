FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY Prototype.RabbitMq.Publish/Prototype.RabbitMq.Publish.csproj Prototype.RabbitMq.Publish/
COPY Prototype.RabbitMq.EventBus/Prototype.RabbitMq.EventBus.csproj Prototype.RabbitMq.EventBus/
COPY Prototype.RabbitMq.EventBusRabbitMQ/Prototype.RabbitMq.EventBusRabbitMQ.csproj Prototype.RabbitMq.EventBusRabbitMQ/
RUN dotnet restore Prototype.RabbitMq.Publish/Prototype.RabbitMq.Publish.csproj
COPY . .
WORKDIR /src/Prototype.RabbitMq.Publish
RUN dotnet build Prototype.RabbitMq.Publish.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Prototype.RabbitMq.Publish.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Prototype.RabbitMq.Publish.dll"]
