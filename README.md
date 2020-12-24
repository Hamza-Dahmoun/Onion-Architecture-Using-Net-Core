# Enterprise Application with ASP.NET Core MVC respecting Onion Architecture
In February 2020 I did an Asp .Net Core workshop and thanks to the teacher Mr. Farouk Belhocine we have implemented Onion Architecture using Asp .Net Core. Lets try re-building it again!




# Layers & Projects:

This architecture is based on four portions:

1. Application Core (Reusable): consists of 4 projects which are reusable components to assure the clean architecture, they are the abstraction:

- Reusable.Data.Abstractions: contains IRepository and IUnitOfWork interfaces.

- Reusable.Data.Core: contains Repository and UnitOfWork implementations (GenericRepository.cs and UnitOfWork.cs).

- Reusable.Business.Core: contains a generic implementation of a business service. (IBusinessService.cs and GenericBusinessService.cs)

- Reusable.Domain.Core: contains commonly used interfaces and implementations for Domain entities. (IEntity.cs and PagedResult.cs).


These 4 projects are reusable components, they are considered as the starting point of any new application.


2. Application Domain folder containing 2 Layers: 

-	ApplicationName.Domain project assuring Data Access Layer. It contains all Entities (models) and Enumerations type.

-	ApplicationName.Business projet assuring Business Layer. It contains all BusinessService files and Resources files to localize business messages.

3. Infrastructure Layer (Infrastructure folder): 
Contains one project ApplicationName.Data it contains the DbContext and the migrations

4. Presentation Layer (Presentation folder): 
Consists of two projects  ApplicationName.Api & ApplicationName.Web



