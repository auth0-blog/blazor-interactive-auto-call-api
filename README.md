This repository contains a Blazor Web application with Interactive Auto render mode secured with [Auth0](https://auth0.com/) and calling an internal and an external API.

The following article describes the implementation details: [Call Protected APIs from a Blazor Web App](https://auth0.com/blog/call-protected-api-from-blazor-web-app/).

## To run the applications:

Clone the repo: `git clone https://github.com/auth0-blog/blazor-interactive-auto-call-api`

To run the applications:

1. Go to the `ExternalAPI` folder
2. Follow the instructions in the `README.md` file to register, configure, and run the API.
3. Move to the `BlazorIntAuto` folder 
4. Add your Auth0 credentials to the `appsettings.json` configuration file.
5. Type `dotnet run` in a terminal window.
6. Point your browser to `https://localhost:7255`.

## Requirements:

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on your machine
- An [Auth0](https://auth0.com/) account.

