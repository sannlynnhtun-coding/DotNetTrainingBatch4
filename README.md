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

- **2024-04-09**: Console Application Development
- **2024-04-10**: Ado.Net CRUD Implementation
- **2024-04-22**: Dapper CRUD Implementation
- **2024-04-23**: EF Core Integration
- **2024-04-24**: ASP.NET Core Web API Blog CRUD, Console App Folder Structure
- **2024-04-29**: ASP.NET Core Web API Dapper CRUD Implementation
- **2024-05-01**: ASP.NET Core Web API Ado.Net CRUD, Dapper Custom Service, Ado.Net Custom Service Implementation
- **2024-05-07**: Layered (N-Layer) Architecture, Burma Project Idea Discussion for API, JSON data to API
- **2024-05-08**: Console App CRUD with API using HttpClient & RestClient (RestSharp)

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

