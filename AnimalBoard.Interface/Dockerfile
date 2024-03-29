#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["AnimalBoard.Interface/AnimalBoard.Interface.csproj", "AnimalBoard.Interface/"]
RUN dotnet restore "AnimalBoard.Interface/AnimalBoard.Interface.csproj"
COPY . .
WORKDIR "/src/AnimalBoard.Interface"
RUN dotnet build "AnimalBoard.Interface.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AnimalBoard.Interface.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AnimalBoard.Interface.dll"]