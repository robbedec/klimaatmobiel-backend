FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["projecten3-1920-backend-klim03/projecten3-1920-backend-klim03.csproj", "projecten3-1920-backend-klim03/"]
RUN dotnet restore "projecten3-1920-backend-klim03/projecten3-1920-backend-klim03.csproj"
COPY . .
WORKDIR "/src/projecten3-1920-backend-klim03"
RUN dotnet build "projecten3-1920-backend-klim03.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "projecten3-1920-backend-klim03.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "projecten3-1920-backend-klim03.dll"]