# Weapsy
Weapsy is an ASP.NET Core CMS based on DDD and CQRS.

Each writing operation is represented by a command. After the operation is completed successfully one or more events are published by an internal dispatcher.
It's extremely easy to subscribe to any domain events.

Weapsy can be extended with custom apps.
An app can display content through modules or pages.
The first app included is the Text app used to create html modules.
The second one is going to be the Blog app.

**Wiki**: https://github.com/weapsy/Weapsy/wiki

# Prerequisites

- Visual Studio 2015 Update 3
- .NET Core 1.0 for Visual Studio (https://www.microsoft.com/net/core#windows)
- SQL Server

# Technology

- C#
- ASP.NET Core MVC and Web Api
- JavaScript, jQuery, KnockoutJS
- Entity Framework Core
- SQL Server

# How to run on local

- Create a SQL database (weapsy.dev)
- Run install-full.sql script (in scripts folder)
- Open the Weapsy.sln solution in Visual Studio
- Run (F5 or Ctrl+F5). _Note: there could be an internal server error the first time the app runs. In case that happens just refresh the page, I'm working on fixing the issue._
- Login using these credentials:
  - email: admin@default.com
  - password: Ab1234567!

# Roadmap

https://github.com/weapsy/Weapsy/wiki/Roadmap

# How to contribute

Please create issues to report bugs, suggest new functionalities, ask questions or just share your thoughts about the project. I will really appreciate your contribution, thanks.
