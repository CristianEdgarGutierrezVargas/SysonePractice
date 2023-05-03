# The `FROM` instruction specifies the base image. You are
# extending the `microsoft/aspnet` image.
#FROM microsoft/aspnet
#WORKDIR /inetpub/wwwroot
# The final instruction copies the site you published earlier into the #container.
#COPY /bin/Release/net7.0/publish/ /inetpub/wwwroot



# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env
WORKDIR /MVCnet7
COPY MVCnet7/*.csproj .
RUN dotnet restore
COPY MVCnet7 .
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime
WORKDIR /publish
COPY --from=build-env /publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "MVCnet7.dll"]
