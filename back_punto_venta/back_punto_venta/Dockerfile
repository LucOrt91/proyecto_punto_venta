#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["back_punto_venta/back_punto_venta.csproj", "back_punto_venta/"]
RUN dotnet restore "back_punto_venta/back_punto_venta.csproj"
COPY . .
WORKDIR "/src/back_punto_venta"
RUN dotnet build "back_punto_venta.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "back_punto_venta.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "back_punto_venta.dll"]