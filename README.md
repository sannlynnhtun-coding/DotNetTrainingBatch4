# DotNetTrainingBatch4

## Folder Structure

```plaintext
SLHDotNetCore
│
├── SLHDotNetCore.ConsoleApp
│   ├── Program.cs
│   └── (Other files related to the console application)
│
├── SLHDotNetCore.RestApi
│   ├── Controllers
│   ├── Models
│   ├── DataAccess
│   └── (Other files related to the REST API)
│
└── (Other project folders)
```

## Key Dates & Development Timeline


- **2024-03-30**: Microsoft SQL Server Installation & Visual Studio Installation
- **2024-04-04**: C# Basic & SQL Basic
- **2024-04-04**: [VS Code Installation](https://youtu.be/O4dCgYicoDg), Installers (JetBrains DatGrip, JetBrains Rider, Beyond Compare)
- **2024-04-09**: Console Application Development
- **2024-04-10**: Ado.Net CRUD Implementation
- **2024-04-22**: Dapper CRUD Implementation
- **2024-04-23**: EF Core Integration
- **2024-04-24**: ASP.NET Core Web API Blog CRUD, Console App Folder Structure
- **2024-04-29**: ASP.NET Core Web API Dapper CRUD Implementation
- **2024-05-01**: ASP.NET Core Web API Ado.Net CRUD, Dapper Custom Service, Ado.Net Custom Service Implementation
- **2024-05-07**: Layered (N-Layer) Architecture, Burma Project Idea Discussion for API, JSON data to API
- **2024-05-08**: Console App CRUD with API using HttpClient 
- **2024-05-09**: Console App CRUD with API using RestClient (RestSharp) 
- **2024-05-13**: Myanmar Proverbs API, Pizza API
- **2024-05-15**: Pizza API using Query with Dapper Service
- **2024-05-15**: Console App CRUD with API using Refit, Windows Forms Intro
- **2024-05-15**: .NET Framework vs .NET Core vs .NET
- **2024-05-15**: Windows Forms - Hello World
- **2024-05-15**: Windows Forms Blog - Create
- **2024-05-27**: Windows Forms Blog - List
- **2024-05-28**: Windows Forms Blog - Edit, Delete
- **2024-05-28**: If Case, Switch Case
- **2024-05-28**: Sql Injection
- **2024-05-28**: NLayer Architecture
- **2024-05-29**: JavaScript Blog CRUD
- **2024-05-29**: Html + JavaScript Blog CRUD
- **2024-06-03**: jQuery Plugin (SweetAlert, Notiflix)
- **2024-06-04**: jQuery Plugins - DataTable, Date Picker, Ladda Button, iCheckbox, Custom Confirm Message
- **2024-06-10**: Dependency Injection
- **2024-06-10**: Dependency Injection - Code
- **2024-06-11**: JetBrains Rider Installation
- **2024-07-08**: ASP.NET Core Minimal API CRUD
- **2024-07-08**: ASP.NET Core Web MVC Blog List
- **2024-07-08**: ASP.NET Core Web MVC Blog Create
- **2024-07-08**: ASP.NET Core Web MVC Blog Edit Update Delete
- **2024-07-08**: AsNoTracking
- **2024-07-31**: ASP.NET Core MVC Ajax (no voice / voice error - goto 2024-08-18)
- **2024-08-03**: ASP.NET Core Apex Chart - Pie Chart
- **2024-08-03**: ASP.NET Core Chart.js, HighCharts, CanvasJs, Text Log
- **2024-08-03**: Db Log Part - 1
- **2024-08-03**: Db Log Part - 2
- **2024-08-03**: Realtime Chat using SignalR Part - 1
- **2024-08-03**: Realtime Chat using SignalR Part - 2
- **2024-08-03**: Realtime Chart using SignalR
- **2024-08-04**: EFCore Database First
- **2024-08-11**: ASP.NET Core MVC + UI Design (Admin LTE)
- **2024-08-11**: Blazor Server, Blazor Web Assembly
- **2024-08-11**: About Blazor Web Assembly Project
- **2024-08-11**: About Blazor Web Assembly Project
- **2024-08-18**: ASP.NET Core MVC Ajax - V2


## Project Components

### 1. **Console Application**
   - A simple console application showcasing CRUD operations using Ado.Net, Dapper, and EF Core.
   
### 2. **REST API**
   - A RESTful API built with ASP.NET Core Web API, featuring CRUD operations and integrating with various data access technologies such as Ado.Net, Dapper, and EF Core.

### 3. **Entity Framework Core (EF Core)**
   - **Code First Approach**
   - **Database First Approach**
   - Commands used to scaffold models from an existing database:
   
     ```bash
     Scaffold-DbContext "Server=.;Database=DotNetTrainingBatch4;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context AppDbContext
     ```
     
   - Alternate command:
   
     ```bash
     dotnet ef dbcontext scaffold "Server=.;Database=DotNetTrainingBatch4;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -c AppDbContext -f
     ```

### 4. **Blazor**
   - **Blazor Server**
   - **Blazor WebAssembly (Client + Server)**
   - Blazor WebAssembly integrated with ASP.NET Core Web API.

## Additional Concepts & Techniques

### 1. **MVC Pattern**
   - **Model**: Data representation.
   - **View**: User Interface (UI).
   - **Controller**: Logic to process user requests and generate appropriate views.

### 2. **AsNoTracking in EF Core**
   - Optimize read-only queries by disabling change tracking in EF Core.
   
### 3. **Ajax**
   - Asynchronous JavaScript and XML for partial updates in web pages.

### 4. **ViewBag, ViewData, TempData, Session**
   - Techniques for passing data between controllers and views.

### 5. **Dependency Injection**
   - Managing dependencies between classes and services within the project.

## Git Operations

To clear your Git local cache:

```bash
git rm -r --cached .
git add .
git commit -am 'git cache cleared'
git push
```

## Development Environment

- **.NET Framework**: Versions 1 to 4.8.1
- **.NET Core**: Versions 1 to 3.1
- **.NET**: Versions 5 to 9

## Useful Commands & Techniques

- Use `select * from Tbl_Blog with (nolock)` for reading data without locking the table in SQL Server.
- Client-Server communication:
  - Client A pushes updates to the server.
  - Server broadcasts changes to all clients, ensuring synchronization.

## Thank You!

Thank you for using this project! Your contributions and feedback are highly appreciated. If you have any questions or need further assistance, feel free to reach out.

---

**Note**: This README is a high-level overview. Please refer to individual project folders and files for detailed documentation.

---

## Illustration

![What is an API - Postman Illustration](https://voyager.postman.com/illustration/diagram-what-is-an-api-postman-illustration.svg)

---

