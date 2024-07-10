[Clear git local cache](https://stackoverflow.com/questions/41863484/clear-git-local-cache)
```bash
git rm -r --cached .
git add .
git commit -am 'git cache cleared'
git push
```


https://medium.com/@buttertechn/qa-testing-what-is-dev-sit-uat-prod-ac97965ce4f

EF Core
- Code First
- Database First

https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx

```
Scaffold-DbContext "Server=.;Database=DotNetTrainingBatch4;User ID=sa;Password=sasa@123;TrustServerCertificate=True;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context
```

> UI + Business Logic + Data Access + Db
> Mobile, Web => API => Database
> C# => Db

SLHDotNetCore (Folder Structure)
> - SLHDotNetCore.ConsoleApp
> - SLHDotNetCore.RestApi


- 2024-04-09 Console App
- 2024-04-10 Ado.Net CRUD
- 2024-04-22 Dapper CRUD
- 2024-04-23 EFCore
- 2024-04-24 ASP.NET Core Web API Blog CRUD, Console App Folder Structure
- 2024-04-29 ASP.NET Core Web API Dapper CRUD
- 2024-05-01 ASP.NET Core Web API Ado.Net CRUD, Dapper Custom Service, Ado.Net Custom Service
- 2024-05-07 Layered (N-Layer) Architecture, Burma Project Idea Discussion For API, Burma Project Idea JSON data to API
- 2024-05-08 Console App CRUD with API using HttpClient & RestClient (RestSharp)



![!Alter Text](https://voyager.postman.com/illustration/diagram-what-is-an-api-postman-illustration.svg)


.net framework (1, 4.8.1)
.net core (1, 3.1)
.net (5, 9)


MVC
Model
View 
Controller

Controller => Processing => View(Model == Dto) => UI (cshtml)

https://localhost:3000/Home/Index

Submit

---

AsNoTracking

---

Ajax

---

ViewBag, ViewData, TempData, Session 

---

Dependency Inject with Order

---


1
2
3 - update 8
4 - update 9
5
6 x
7 x

Commit / Uncommit

select * from Tbl_Blog with (nolock)

https://github.com/chartjs/Chart.js/blob/master/docs/scripts/utils.js