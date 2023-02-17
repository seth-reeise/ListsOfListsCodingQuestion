FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ListsOfLists/ListsOfLists.csproj", "ListsOfLists/"]
RUN dotnet restore "ListsOfLists/ListsOfLists.csproj"
COPY . .
WORKDIR "/src/ListsOfLists"
RUN dotnet build "ListsOfLists.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ListsOfLists.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ListsOfLists.dll"]
