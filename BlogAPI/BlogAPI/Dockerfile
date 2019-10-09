FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["BlogAPI/BlogAPI.csproj", "BlogAPI/"]
COPY ["Infraestructure/Infraestructure.csproj", "Infraestructure/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Application/Application.csproj", "Application/"]
RUN dotnet restore "BlogAPI/BlogAPI.csproj"
COPY . .
WORKDIR "/src/BlogAPI"
RUN dotnet build "BlogAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlogAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlogAPI.dll"]
