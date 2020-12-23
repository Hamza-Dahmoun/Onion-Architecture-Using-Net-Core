# Enterprise Application with ASP.NET Core MVC respecting Onion Architecture
In February 2020 I did an Asp .Net Core workshop and thanks to the teacher Mr. Farouk Belhocine we have implemented Onion Architecture using Asp .Net Core. Lets try re-building it again!




# Layers & Projects:

This architecture is based on four portions:

1- Application Core: consists of 4 projects which are reusable components to assure the clean architecture, they are the abstraction:

- CompanyName.AppName.Abstractions: contains IRepository and IUnitOfWork interfaces.

- CompanyName.AppName.Core: contains Repository and UnitOfWork implementations.

- CompanyName.AppName.Core: contains a generic implementation of a business service.

- CompanyName.AppName.Core: contains commonly used interfaces and implementations for Domain entities.

2- Application Domain folder containing 2 Layers: 

-	CompanyName.AppName.Data project assuring Data Access Layer. It contains all Entities and Enums.

-	CompanyName.AppName.Business projet assuring Business Layer. It contains all BusinessService files and Resources files.

3- Infrastructure Layer (Infrastructure folder): 
Contains one project CompanyName.AppName.Data it contains the DbContext and the migrations

4- Presentation Layer (Presentation folder): 
Consists of two projects  CompanyName.AppName.Api & CompanyName.AppName.Web
