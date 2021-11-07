FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["dot-net-core-practice-demo/dot-net-core-practice-demo.csproj", "dot-net-core-practice-demo/"]
RUN dotnet restore "dot-net-core-practice-demo/dot-net-core-practice-demo.csproj"
COPY . .
WORKDIR "/src/dot-net-core-practice-demo"
RUN dotnet build "dot-net-core-practice-demo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dot-net-core-practice-demo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dot-net-core-practice-demo.dll"]
