# _To Do List with MySQL and EF Core_

#### By _**Gareth Grindeland**_

#### _A web application built with C#/.NET using MVC and RESTful routing._

## Technologies Used

* Git
* C#/.NET version 6.0.402
* MySQL
* Enity Framework Core version 6.0.0
* HTML & CSS
* LINQ

## Description

_This is a basic console application that allows users to input categories and lists of to do items. This project was completed for week 9 of Epicodus to practice using the MVC model with objects nested inside of objects._

## Setup/Installation Requirements

* _Clone this repository to your desktop._
* _Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory at ```./ToDoList-EFCore/ToDoList"```._
* _Within the production directory "ToDoList", create a new file called ```appsettings.json```._
* _Within ```appsettings.json```, put the following code, replacing the uid and pwd values (in the brackets below) with your own username and password for MySQL._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list_with_ef_core;uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
#### To Run the App in the browser:
* _Navigate to this project's production directory named "ToDoList"._
* _Run ```dotnet watch run``` in the command line to start the application in development mode with a watcher. This will open the webpage in your browser._
* _To exit out of the application, you can use the keyboard command "CTRL+C" on Mac and Windows._
* _Optionally, you can run ```dotnet build``` within the "ToDoList" directory to compile this app without running it._

## File Structure
```
ToDoList.Solution
├── ToDoList
│   ├── Controllers
│   │   ├── CategoriesController.cs
│   │   ├── HomeController.cs
│   │   └── ItemsController.cs
│   ├── Models
│   │   ├── Category.cs
│   │   └── Item.cs
│   ├── Program.cs
│   ├── Properties
│   │   └── launchSettings.json
│   ├── ToDoList.csproj
│   └── Views
│       ├── Home
│       │   └── Index.cshtml
│       └── Items
│           ├── DeleteAll.cshtml
│           ├── Index.cshtml
│           ├── New.cshtml
│           └── Show.cshtml
└── ToDoList.Tests
    ├── ModelTests
    │   ├── CategoryTests.cs
    │   └── ItemTests.cs
    └── ToDoList.Tests.csproj
```

## Known Bugs

* _No known bugs_

## License

_MIT License_

_Copyright (c) 2023 Gareth Grindeland_