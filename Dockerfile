FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["materi_docker.csproj", "./"]
RUN dotnet restore "./materi_docker.csproj"
COPY . .
WORKDIR /src/.
RUN dotnet build "materi_docker.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "materi_docker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "materi_docker.dll"]
