# ---
# First stage (build)
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /app

# Copy solution as distinct layer
COPY Web.sln .
COPY Web/Web.csproj ./Web/
RUN dotnet restore

# Copy everything else and build
COPY Web/. ./Web/
WORKDIR /app/Web
RUN dotnet publish -c Release -o out

# ---
# Second stage (execution)
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime

WORKDIR /app
COPY --from=build /app/Web/out ./

# Run on localhost:8779
ENV ASPNETCORE_URLS http://+:8080
EXPOSE 8080

# Drop privileges
USER 1000

ENTRYPOINT ["dotnet", "Web.dll"]
