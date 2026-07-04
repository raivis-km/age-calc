# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ./src/Calculator.Api/ ./Calculator.Api/
RUN dotnet restore ./Calculator.Api/Calculator.Api.csproj
RUN dotnet publish ./Calculator.Api/Calculator.Api.csproj -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "Calculator.Api.dll"]
