FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /src
COPY . /src
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
EXPOSE 80
WORKDIR /app
COPY --from=build-env /src/out .
ENTRYPOINT ["dotnet", "Fullstuck.EnergieService.dll"]