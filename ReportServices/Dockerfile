FROM microsoft/dotnet:2.1-runtime AS base 
RUN apt-get update \ 
    && apt-get install -y --allow-unauthenticated \ 
        libc6-dev \ 
        libgdiplus \ 
        libx11-dev \ 
    && rm -rf /var/lib/apt/lists/*
ENV DOTNET_USE_POLLING_FILE_WATCHER=true
WORKDIR /Host
COPY Host .
ENV ASPNETCORE_URLS http://+:6000
EXPOSE 6000
ENTRYPOINT ["dotnet", "ReportServices.dll"]
