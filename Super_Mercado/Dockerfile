FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["Super_Mercado/Super_Mercado.csproj", "Super_Mercado/"]
RUN dotnet restore "Super_Mercado/Super_Mercado.csproj"
COPY . .
WORKDIR "/src/Super_Mercado"
RUN dotnet build "Super_Mercado.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Super_Mercado.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Super_Mercado.dll"]