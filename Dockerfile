FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

WORKDIR /src
COPY src/App/App.csproj .
RUN dotnet restore

COPY src/App .
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0 as app
WORKDIR /app
COPY --from=build /app .

ENV ASPNETCORE_URLS "http://*:5000"
CMD ["dotnet", "App.dll"]
