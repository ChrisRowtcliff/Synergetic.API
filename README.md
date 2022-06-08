# Synergetic.API
A .NET Core, Standard and Framework async implementation of the Synergetic API.
The API has been developed against the API at Synergetic version 70.16.1

Synergetic API developer documentation can be found at https://developer.synergetic.net.au/

### Note: Only GET requests have been tested so far


## Usage

### Initialisation
Before you can use the Synergetic API client, you first need to configure it in your application.

#### Automatically acquiring a token
By default, the API client to automatically acquires the token if it has not previously been acquired, or has expired.
For a web application, call the following code in Startup.cs

```` 
SynergeticClient.Initialise("{ClientId}", "{ClientSecret}", "{SynergeticAPIUrl}"); 
````

You do not need to call the AcquireToken method (below) when doing this.

#### Manually acquiring a token
There may be times where you want to control the timing of the extra network hop when acquiring a token. By default, the API client automatically acquires a token, or refreshes it if it has expired.
For a web application, call the following code in Startup.cs

```` 
SynergeticClient.Initialise("{ClientId}", "{ClientSecret}", "{SynergeticAPIUrl}", automaticallyAcquireToken: false); 
````

Next acquire a token to use for subsiquent API calls

```` 
SynergeticClient.AcquireToken(); 
````

### Using the API
Once you have initialised the client, you can query the Synergetic API by creating an instance of the appropiate service and using the Get/Create/Update methods.

Current services available are:
* LookupTableService
* StudentService
* StudentAllergyService
* StudentContactsService
* StudentResultsService
* MedicalConditionsService
* MedicalDetailsService
* MedicalImmunisationsService


#### Querying the API

```
using Synergetic.Api.Services.Students;

var studentService = new StudentService();
var students = studentService.Get();

```


##### Updating or Creating Records

##### NOTE: These methods are untested

Following the Synergetic API spec, a list of new items, or items to update can be posted to the API.


```
using Synergetic.Api.Services.StudentAllergies;

var studentAllergyService = new StudentAllergyService();

var allergies = new List<CreateStudentAllergyRequest>(){ ... }

var results = studentService.Create(allergies);

```

These methods will return an 'EntityResult' object.