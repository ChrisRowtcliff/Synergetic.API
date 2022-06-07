# Synergetic.API
A .NET Core, Standard and Framework async implementation of the Synergetic API

###Note: Only GET requests have been tested so far

## Usage

### Initialisation
Before you can use the Synergetic API client, you first need to configure it in your application.
This only has to be done once and calls the token issuance endpoint.

For a web application, call the following code in Startup.cs

``` await SynergeticClient.Initialise("{ClientId}", "{ClientSecret}", "{SynergeticAPIUrl}"); ```


### Querying the API

```
using Synergetic.Api.Services.Students;

var studentService = new StudentService();
var students = studentService.Get();

```
