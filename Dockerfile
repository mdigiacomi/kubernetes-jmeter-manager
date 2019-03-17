FROM mcr.microsoft.com/dotnet/core/runtime:2.1.9-alpine3.9 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src
COPY ["JMeter-Manager/JMeter-Manager.csproj", "JMeter-Manager/"]
RUN dotnet restore "JMeter-Manager/JMeter-Manager.csproj"
COPY . .
WORKDIR "/src/JMeter-Manager/"
RUN dotnet build "JMeter-Manager.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "JMeter-Manager.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "JMeter-Manager.dll"]