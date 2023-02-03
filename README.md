# Starkiller API

This project was generated the dotnet CLI. The goal of this project is to provide a backend for Project Starkiller, which can be found here: [Project Starkiller](https://github.com/johnnybouder/starkiller).

## Running locally using the .NET SDK

```
# Start the server
dotnet run
```

## Running locally using Docker

```
# Build the project for release
dotnet publish --os linux --arch x64 -c Release -p:PublishProfile=DefaultContainer

# Start the container
docker run --rm --name starkiller-api -p 5010:80 -d starkiller-api:1.0.0
```
