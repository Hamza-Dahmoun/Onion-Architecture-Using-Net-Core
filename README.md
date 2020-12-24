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


# How To Use It
1. Add new models inside Entities folder of CompanyName.AppName.Domain project

2. Do the necessary migrations inside the project CompanyName.AppName.Infrastructure

3. If you need Enumeration type add it inside Enum folder of CompanyName.AppName.Domain project

4. Add BusinessService files of the new models inside CompanyName.AppName.Business project. It is there where you should create your business rules,
take PromotorBusinessService as an example. New BusinessService files should be registered in Startup file of the Web project before its use.

 Business rules are added inside onAdding() method of BusinessServices files

5. When you need to add a referentiel class it should inherit from Referentiel.cs, and uses ReferentielBusinessService.cs as its business layer

6. We should change AppSettings.ApiBaseUrl inside appsettings.json file according to the host so that the Api calls work correctly

7. Whenever you need to use a business service from Business project inside Api project do not forget to register its service inside Api project startup file

8. Whenever you need to use a business service from Business project inside MVC project do not forget to register its service inside MVC project startup file

9. New messages or labels should be added to ressources files and translated there, then use the translation how it is needed

10. Frontend libraries like bootstrap, fontawesome, jquery are already installed

11. Whenever you need to use fontawesome library load the partialView _fontAwesome

12. Whenever you need to use select2 library load th partialViews _select2Style & _select2Script

13. Whenever you need to use datatables library load the partialViews _datatablesStyle & datatablesScript




