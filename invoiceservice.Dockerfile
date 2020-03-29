FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /src
COPY /InvoiceService /src
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
EXPOSE 80
EXPOSE 443

WORKDIR /app
COPY --from=build-env /src/out .
ENTRYPOINT ["dotnet", "Managerize.InvoiceService.dll"]