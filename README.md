# Academic Reference Manager API

Welcome to the Academic Reference Manager WEB API! This API stores information about a library of articles, journals and publications. With it, you can manage loans of publications to friends and friends' reviews of the publications.  

## Installation

If you don't have Dotnet 2.2 installed on your computer you can download it here: 
https://dotnet.microsoft.com/download

Be sure you select the correct OS for your computer and to select version 2.2, as the server won´t run otherwise.

If you want to run the scripts in the scripts folder, you will need python 3.
https://www.python.org/downloads/

Again, make sure to select the correct OS.

## Usage

### Running server
Once you have Dotnet installed on your computer you can change directory to AcademicReferenceManager.WebApi and run the command:
```bash 
dotnet run
``` 
to start the server.

Once the server has started, you can see all the commands available by navigating to the base URL (default is localhost:5000) in your browser of choice.

### Running tests
To run tests, go back to the root project folder and change directory to AcademicReferenceManager.Tests and run:
```bash 
dotnet test
```
in either the IntegrationTests or UnitTests folder in order to run integration and unit tests respectively.


## System description
The system is roughly broken down into 3 subsystems

#### The controllers
Handles routing from clients to the API. Handles authorization and model validation.

#### The services
Splits complex calls from the controllers into 4 specific groups; publications, users, reviews and loans to simplify calls to the repository. Also handles mapping between entities and data transfer objects. 

#### The repositories
Handles reading and writing entities from the server to an sqlite database.



### Authorization 
The API also supports 3 levels of authorization.

#### Administrators
Have full create, read, update and delete (CRUD) access to the entire API, being able to add publications and users as well as being able view reports at the /users and /publications base routes (see [Reports](#Reports) for more information). 
Add value ```admin``` to the ```Authorization``` header of your API call to authorize as administrator.

#### Authenticated users
Have full access to commands under the route /users/{userId}. That is, borrow and return publications, add or remove reviews for publications and view recommendations of publications based on rating.
Add value ```auth``` to the ```Authorization``` header of your API call to authorize as administrator.


#### Anonymous users
Can view list of publications and their reviews.

## Reports
Administrators can get a list of users and publications that have had an ongoing loan for a specified duration at a specified point in time.
To do this, add one or both of the query parameters ```LoanDate``` and ```LoanDuration``` to the URL of your API call.
e.g. 
```
/api/publications?LoanDuration=20&LoanDate=2017-05-06
```

## Design patterns used
Our intent was to create a server that is as loosely coupled as possible as that would allow us to test the server more easily. To do this, we utilized seperated interfaces to avoid controller dependency on actual implementation and stub services for testing. 
.Net core is built with good support for inversion of control by having native implementations of transients and singletons, which also helped keeping the code loosely coupled.
