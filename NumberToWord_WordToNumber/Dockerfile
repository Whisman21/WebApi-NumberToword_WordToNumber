#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NumberToWord_WordToNumber/NumberToWord_WordToNumber.csproj", "NumberToWord_WordToNumber/"]
RUN dotnet restore "./NumberToWord_WordToNumber/NumberToWord_WordToNumber.csproj"
COPY . .
WORKDIR "/src/NumberToWord_WordToNumber"
RUN dotnet build "./NumberToWord_WordToNumber.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./NumberToWord_WordToNumber.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NumberToWord_WordToNumber.dll"]