# CallCentre
Angular ASP.NET Web API demo

CQRS/CQS pattern has been implemented in the application to segregate the responsibility of commands and queries. Commands and handlers are used to perform insert, update and delete operations, queries are used to fetch data from the database and display on the screen.

CQRS - http://martinfowler.com/bliki/CQRS.html

CQS - http://martinfowler.com/bliki/CommandQuerySeparation.html

In order to follow TDD (Test Driven Development), BDD (Behavior Driven Design) is preferable. And to write a specific behavior of the requirement in to the code we need types. So types would be commands and queries in which a specific behavior can be encapsulated and make it highly testable and maintainable.
So the design of the application is divided in layers below to make it loosely coupled and to get high cohesion.

1. Data Access Layer (Repository, Entity Framework)
2. Business Logic Layer (Commands, Queries, Events)
3. API Layer (Routes, Controllers, Security)
4. Presentation Layer (Services, Controllers, Views, Components)

In order to run the demo application follow steps below

1. Download the solution or clone repository
2. Open Solution
3. Restore NuGet Packages - By building the solution
4. Open web.config and update connection string (key = CallCentreContext)
5. Open NuGet Package Manager Console
6. Select project CallCentre.Core
7. Run Update-Database command (This command will create database, create table and insert demo data)
8. Run the application :-)

In order to run JavaScript unit tests following node packages are required to be installed using command npm. To install node visit https://nodejs.org/download/.

1. Karma - npm install -g karma
2. Karma Jasmine - npm install -g karma-jasmine
3. Karma Chrome Launcher - npm install -g karma-chrome-launcher
4. Karma Command Line - npm install -g karma-cli

JavaScript unit tests can be run using following two methods

1. ReSharper
2. From command prompt using command "karma start karma.conf.js" in web project directory
