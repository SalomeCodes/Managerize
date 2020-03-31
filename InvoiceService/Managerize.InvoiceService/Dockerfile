#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Managerize.InvoiceService/Managerize.InvoiceService.csproj", "Managerize.InvoiceService/"]
COPY ["Managerize.InvoiceService.BLL/Managerize.InvoiceService.BLL.csproj", "Managerize.InvoiceService.BLL/"]
COPY ["Managerize.InvoiceService.DAL/Managerize.InvoiceService.DAL.csproj", "Managerize.InvoiceService.DAL/"]
COPY ["Managerize.InvoiceService.Models/Managerize.InvoiceService.Models.csproj", "Managerize.InvoiceService.Models/"]
COPY ["Managerize.InvoiceService.CompositionRoot/Managerize.InvoiceService.CompositionRoot.csproj", "Managerize.InvoiceService.CompositionRoot/"]
RUN dotnet restore "Managerize.InvoiceService/Managerize.InvoiceService.csproj"
COPY . .
WORKDIR "/src/Managerize.InvoiceService"
RUN dotnet build "Managerize.InvoiceService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Managerize.InvoiceService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Managerize.InvoiceService.dll"]