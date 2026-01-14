# Set the major version of dotnet
ARG DOTNET_VERSION=8.0

# Stage 1 - Build the app using the dotnet SDK
FROM mcr.microsoft.com/dotnet/sdk:${DOTNET_VERSION}-azurelinux3.0 AS build
WORKDIR /build

# Copy the solution file and source code
COPY ./GovUK.Dfe.LocalSendReformPlans.Web.sln ./
COPY ./src/ ./src/

# Mount GitHub Token as a Docker secret, add NuGet source, and build the solution
RUN --mount=type=secret,id=github_token \
    --mount=type=cache,target=/root/.nuget/packages \
    dotnet restore GovUK.Dfe.LocalSendReformPlans.Web.sln && \
    dotnet build GovUK.Dfe.LocalSendReformPlans.Web.sln --no-restore -c Release && \
    dotnet publish GovUK.Dfe.LocalSendReformPlans.Web.sln --no-build -o /app

# Stage 2 - Build a runtime environment
FROM mcr.microsoft.com/dotnet/aspnet:${DOTNET_VERSION}-azurelinux3.0 AS final
WORKDIR /app
LABEL org.opencontainers.image.source="https://github.com/DFE-Digital/external-applications-web"
LABEL org.opencontainers.image.description="LSRP - App"


COPY --from=build /app /app
COPY ./script/web-docker-entrypoint.sh /app/docker-entrypoint.sh
RUN chmod +x ./docker-entrypoint.sh

USER $APP_UID
