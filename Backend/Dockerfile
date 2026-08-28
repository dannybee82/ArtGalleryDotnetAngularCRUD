FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["ArtGalleryWebApi/ArtGalleryWebApi.csproj", "ArtGalleryWebApi/"]
COPY ["RepositoryLayer/RepositoryLayer.csproj", "RepositoryLayer/"]
COPY ["ServiceLayer/ServiceLayer.csproj", "ServiceLayer/"]

RUN dotnet restore ./ArtGalleryWebApi/ArtGalleryWebApi.csproj

COPY . .

RUN dotnet publish ./ArtGalleryWebApi/ArtGalleryWebApi.csproj \
    -c Release \
    -o /app/publish \
    --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 5001
ENTRYPOINT ["dotnet", "ArtGalleryWebApi.dll"]