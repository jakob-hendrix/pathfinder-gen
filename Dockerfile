# Use the official .NET core runtime as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["PathfinderCharGen.Web.csproj", "./"]
RUN dotnet restore "./PathfinderCharGen.Web.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PathfinderCharGen.Web.csproj" -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish "PathfinderCharGen.Web.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PathfinderCharGen.Web.dll"]
