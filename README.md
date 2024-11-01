# FlightWizard
a C#, .NET and Windows forms project for plane ticket reservation, employing the use of the state and repository design patterns.
<br/>
<br/>
DISCLAIMER: I received help from a student that had this project given to his class.
<br/>
<br/>

## Table of contents
0. [Project status](#Project-status)
1. [Description](#Description)
2. [Project requirements](#Project-requirements)
3. [Key features and functionalities](#Key-features-and-functionalities)
4. [Structure](#Structure)
5. [Installation instructions](#Installation-instructions)
6. [Dependencies](#Dependencies)
7. [System requirements](#System-requirements)
8. [Usage examples](#Usage-examples)
9. [API references](#API-references)
10. [Bugs](#Bugs)
11. [Future improvements](#Futute-improvements)
<br/>

## Project status
Completed and working. Not expecting changes.
<br/>
<br/>

## Description
The purpose and goal of the project is to create a project to reserve plane tickets for flights using C# and .NET and also implementing the state design pattern.

The intended audiences for the project are my erasmus coordinator and myself.
<br/>
<br/>

## Project requirements
The requirements for the project can be viewed in [this file](Design-patterns-english-en.pdf).
<br/>
<br/>

## Key features and functionalities
* KEY FEATURES
  * Users can register an account;
  * Users can login with a registered account;
  * Users can browse flight and reserve seats;
  * Admins can add, edit and delete flights.
* FUNCTIONALITIES  
  * Login and register;
  * SQL database model;
  * Custom user;
  * Sessions;
  * Repositories.
<br/>

## Structutre
Here are some of the important directories and files you need to know about this project:
* `FlightWizard.Business` - Contains the Business logic of the application such as the interfaces for the repository and state pattern, the database model, and session files;
* `FlightWizard.Data` - Contains the `ApplicationContext.cs` file in the `Contexts` folder to configure the SQL connection, migrations and repositories;
* `FlightWizard.UI` - Contains the files for all interactable panels. Contains the `Program.cs` file to start the program.
<br/>

## Installation instructions
1. Download this project;
2. Open the Project in Visual Studio 2022;
3. Open Miscrosoft SQL Server 2022;
4. Ensure you have all the needed dependencies;
5. Ensure you are connecting to your local database;
6. Build the project. You should have access now.
<br/>

## Dependencies
This is a list of dependencies that you need if you want to run the project locally. Aside from an internet connection, you will need:
* Visual Studio 2022;
* Microsoft SQL Server 2022;
* Microsoft .NET framework 8.0.
* NuGet packages:
  * `FlightWizard.Data`:
    * "Microsoft.EntityFrameworkCore" Version="8.0.3";
    * "Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.3";
    * "Microsoft.EntityFrameworkCore.Tools" Version="8.0.3".
<br/>

## System requirements
The project has been developed for the Miscrosoft Windows operating system.
| System requirements  |
| -------------------- | 
| Microsoft Windows 10 | 

<br/>

## Usage examples
We assume that the project has been accessed on the internet or has been run on a local instance.

1. For unregistered users:
 * They can register and/or login.
2. For logged-in users:
 * They can browse flight and reserve seats.
3. For Administrators:
 * They can Add/Edit/Remove flights.
<br/>

## API references
Nothing to mention here.
<br/>
<br/>

## Bugs
- [X]  No bugs have been caught.
<br/>

## Future improvements
- [ ] Remake this project for the web browser or mobile phone;
