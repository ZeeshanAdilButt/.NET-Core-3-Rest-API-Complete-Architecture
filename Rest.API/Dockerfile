FROM microsoft/dotnet:2.2-sdk as build

ARG BUILDCONFIG=RELEASE
ARG VERSION=1.0.0

COPY Rest.API.csproj /build/

RUN dotnet restore ./build/Rest.API.csproj

COPY . ./build/
WORKDIR /build/
RUN dotnet publish ./Rest.API.csproj -c $BUILDCONFIG -o out /p:Version=$VERSION

FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app

COPY --from=build /build/out .

ENTRYPOINT ["dotnet", "Rest.API.dll"]