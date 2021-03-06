### This is an indirect fork of: https://github.com/workcontrolgit/TemplateOnionAPI

I wanted an IDE-agnostic template that's easily cloneable since I usually work outside of Visual Studio for my .NET development. Also adding my (very opinionated) linting.

All credit for the original template source goes to [Fuji Nguyen (@workcontrolgit on GitHub).](https://github.com/workcontrolgit)

# TemplateOnionAPI
Blog - [CRUD, Filter, Sort, Page, and Shape Data in Asp.Net Core REST API with OnionAPI Template](https://medium.com/scrum-and-coke/rapid-prototype-asp-net-core-rest-api-using-onionapi-template-b10eea295655)

Developers can use the Visual Studio template OnionAPI to scaffold a clean architecture REST API solution consisting of five projects

1. Domain - entities and the common models
2. Application - Interfaces, CQRS Features, Exceptions, Behaviors
3. Infrastructure.Persistence - application-specific database access
4. Infrastructure.Shared - common services such as Mail Service, Date Time Service, Mock, and so on
5. WebApi - controllers for REST API resources and endpoints

The underline tech stack provides loosely-coupled and inverted-dependency architecture with good design patterns and practices.

1. ASP.NET CORE 5 — a framework for creating RESTful services, also known as web APIs, using C#
2. Repository Pattern — abstraction layer between the data access layer and the controller
3. CQRS (Command and Query Responsibility Segregation) Pattern — separating read and update operations for a data store to maximize performance, scalability, and security based on MediatR and AutoMapper
4. Entity Framework Core — a lightweight, extensible, open-source, and cross-platform version of the popular Entity Framework data access technology
5. Swashbuckle — the industry standard for REST API documentation and testing
6. Bogus — a realistic, easy to use mock data .NET library for rapid REST API design and testing

# How to install the template during development
Copy the TemplateOnionAPI.zip (in the root of the repo) to the directory of the Visual Studio templates for C# on your desktop.

For Visual Studio 2019, the template folder is at 

C:\Users\[UserName]\Documents\Visual Studio 2019\Templates\ProjectTemplates\Visual C#

Reference: [How to: Create multi-project templates](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-multi-project-templates?view=vs-2019)

