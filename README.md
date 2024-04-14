# dotnetTemplate
A .NET 8+ universal template for building any app using a DDD approach.

This template will generate all the necessary projects for building your app. A console project with a Dockerfile will be created by default, but you can of course create any presentation-type project here (web, API, desktop, mobile, etc.) and add references to all other projects.

When creating a new single app solution with an IDE (in opposition to a solution containing a Server and Client app for instance), check "Put solution and project in the same directory" since the template will create multiple projects. You will get a cleaner folder structure this way.

## Template structure
The template is made of 5 projects, which can be separated into 3 layers :

Presentation
|- YourApp.Console
Infrastructure
|- YourApp.Persistence
|- YourApp.Gateways
Domain
|- YourApp.Application
|- YourApp.Core

### YourApp.Console
This is the default entry point of the application. You can replace it with any presentation-type project such as a website, a desktop app, a mobile app, etc.

You will likely register any dependency injection in that layer, as well as implementing your UI and human-machine interactions.

### YourApp.Persistance
This project implements the storing and retrieving domain-oriented data logics of your application, using a database for example.

It makes use of the Repository and Unit Of Work patterns. We also implement entities in this layer to avoid any stupid behavior that can be caused by implementing those in the Domain layer, and to make work easier for projects made using a database-first approach.

### YourApp.Gateways
You will implement any external resource usage here, such as external API calls or system-specific code.

### YourApp.Application
The domain logic is implemented here in the form of services. If you do prefer a use case approach, or any other way of implementing your logic, you can replace the Services folder with anything else (a UseCases/Interactors one in the example).

### YourApp.Core
The domain objects and interfaces resides here.

Tip: put your interface files in the same way that your solution folder structure is, minus the project folder, like this:
Infrastructure
|- YourApp.Persistence
   |- **Repositories**
      |- AccountRepository.cs
|- YourApp.Gateways
   |- **Clients**
      |- WeatherAPIClient.cs
Domain
|- YourApp.Core
   |- Interfaces
      |- **Repositories**
         |- IAccountRepository.cs
      |- **Clients**
         |- IWeatherAPIClient.cs

## Additional notes
I have created this template based on my own experience. It is heavily inspired by the Clean Architecture, which I really like.

It is of course open to any criticism and contribution! 😊
