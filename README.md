# Geolocation Finder

The Geolocation Finder is a C# application that allows you to retrieve geolocation information for a given IP address using various HTTP methods.
It demonstrates how to make HTTP requests, convert IP addresses to decimal format, and utilize the Factory Method pattern for creating HttpClient instances.

## Table of Contents
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)

## Features
- Retrieve geolocation information for a given IP address.
- Support for both HTTP and HTTPS requests.
- Convert IP addresses to decimal format for API calls using [ip2c.org](https://about.ip2c.org/#about)

## Prerequisites

- The [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- An active internet connection for making HTTP requests.

## Installation

1. Clone the repository:
```git
$ git clone https://github.com/AndreasGkizis/GeoLocation.git
```  
2. Navigate to the project directory:
```bash 
cd GeolocationFinder
```

3. Build the project:

```bash
$ dotnet build
```

## Usage

1. Open the `Program.cs` file and modify the `Main` method as needed.

2. Run the application:
```bash
$ dotnet run
```

3. The application will demonstrate making HTTP requests using different methods and printing the response status code and content.

### Note

**This makes actual calls to the free service which is ip2c, please do not spam them and use reasonably**
