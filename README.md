Here's a refined version of the content:

---

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

- **2024-03-30**: Microsoft SQL Server & Visual Studio Installation
- **2024-04-04**: C# Basics & SQL Basics, [VS Code Installation](https://youtu.be/O4dCgYicoDg), Additional Tools (JetBrains DatGrip, Rider, Beyond Compare)
- **2024-04-09**: Console Application Development
- **2024-04-10**: Ado.Net CRUD Implementation
- **2024-04-22**: Dapper CRUD Implementation
- **2024-04-23**: EF Core Integration
- **2024-04-24**: ASP.NET Core Web API Blog CRUD, Console App Folder Structure
- **2024-04-29**: ASP.NET Core Web API Dapper CRUD Implementation
- **2024-05-01**: ASP.NET Core Web API with Ado.Net CRUD, Dapper & Ado.Net Custom Services
- **2024-05-07**: N-Layer Architecture, Burma Project API Discussion, JSON Data to API
- **2024-05-08**: Console App CRUD via HttpClient API
- **2024-05-09**: Console App CRUD via RestClient (RestSharp)
- **2024-05-13**: Myanmar Proverbs API, Pizza API
- **2024-05-15**: Query-based Pizza API with Dapper Service
- **2024-05-15**: Console App CRUD via Refit, Introduction to Windows Forms
- **2024-05-15**: .NET Framework vs .NET Core vs .NET, Windows Forms "Hello World"
- **2024-05-15**: Windows Forms Blog - Create
- **2024-05-27**: Windows Forms Blog - List
- **2024-05-28**: Windows Forms Blog - Edit, Delete
- **2024-05-28**: If Case, Switch Case, SQL Injection, N-Layer Architecture
- **2024-05-29**: JavaScript Blog CRUD
- **2024-05-29**: HTML + JavaScript Blog CRUD
- **2024-06-03**: jQuery Plugins (SweetAlert, Notiflix)
- **2024-06-04**: jQuery Plugins - DataTable, Date Picker, Ladda Button, iCheckbox, Custom Confirm Message
- **2024-06-10**: Dependency Injection Concepts & Implementation
- **2024-06-11**: JetBrains Rider Installation
- **2024-07-08**: ASP.NET Core Minimal API CRUD, ASP.NET Core MVC Blog Operations (List, Create, Edit, Update, Delete)
- **2024-07-08**: EF Core AsNoTracking
- **2024-07-31**: ASP.NET Core MVC Ajax (Issues - Refer to 2024-08-18)
- **2024-08-03**: ASP.NET Core Apex Chart - Pie Chart, Chart.js, HighCharts, CanvasJS, Text Log, DB Log Parts 1 & 2, Realtime SignalR Chat & Chart
- **2024-08-04**: EF Core Database First Approach
- **2024-08-11**: ASP.NET Core MVC with Admin LTE UI, Blazor Server & WebAssembly (Client + Server)
- **2024-08-18**: ASP.NET Core MVC Ajax - V2

## Project Components

### 1. **Console Application**
   - Showcases CRUD operations using Ado.Net, Dapper, and EF Core.

### 2. **REST API**
   - Built with ASP.NET Core Web API, integrating CRUD operations with Ado.Net, Dapper, and EF Core.

### 3. **Entity Framework Core (EF Core)**
   - **Code First Approach**
   - **Database First Approach**
   - Commands to scaffold models from an existing database:

     ```bash
     Scaffold-DbContext "Server=.;Database=DotNetTrainingBatch4;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context AppDbContext
     ```

     Alternate command:

     ```bash
     dotnet ef dbcontext scaffold "Server=.;Database=DotNetTrainingBatch4;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -c AppDbContext -f
     ```

### 4. **Blazor**
   - **Blazor Server**
   - **Blazor WebAssembly (Client + Server)**
   - Integrated with ASP.NET Core Web API.

## Additional Concepts & Techniques

### 1. **MVC Pattern**
   - **Model**: Data Representation
   - **View**: User Interface (UI)
   - **Controller**: Handles user requests and returns appropriate views

### 2. **EF Core AsNoTracking**
   - Optimizes read-only queries by disabling change tracking.

### 3. **Ajax**
   - Enables asynchronous updates on web pages.

### 4. **Data Passing Techniques**
   - **ViewBag**, **ViewData**, **TempData**, **Session**: For sharing data between controllers and views.

### 5. **Dependency Injection**
   - Manages class and service dependencies.

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

- Use `select * from Tbl_Blog with (nolock)` for reading data without table locking in SQL Server.
- **Client-Server Communication**:
  - Client A sends updates to the server.
  - Server broadcasts changes to all clients for synchronization.

## Enable Cross-Origin Requests (CORS) in ASP.NET Core

This section details how to enable Cross-Origin Requests (CORS) in an ASP.NET Core application.

### Install the CORS Middleware

Add the CORS middleware by installing the `Microsoft.AspNetCore.Cors` package.

```bash
dotnet add package Microsoft.AspNetCore.Cors
```

### Add CORS Services in `Startup.cs`

In `ConfigureServices`, add CORS services and define a policy:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddCors(options =>
    {
        options.AddPolicy("AllowSpecificOrigins",
            builder =>
            {
                builder.WithOrigins("http://example.com", "http://www.contoso.com")
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
    });

    services.AddControllers();
}
```

### Apply the CORS Policy

In the `Configure` method, apply the CORS policy:

```csharp
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseHttpsRedirection();
    app.UseRouting();

    app.UseCors("AllowSpecificOrigins");

    app.UseAuthorization();

    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });
}
```

### Use CORS with Controllers

Enable CORS at the controller level using `[EnableCors]`:

```csharp
[ApiController]
[Route("[controller]")]
public class MyController : ControllerBase
{
    [HttpGet]
    [EnableCors("AllowSpecificOrigins")]
    public IActionResult Get()
    {
        return Ok("CORS is enabled for this endpoint.");
    }
}
```

## Git Commit Message Prefixes

- **feat:** New feature (e.g., `feat: add user login functionality`).
- **fix:** Bug fix (e.g., `fix: resolve issue with user login`).
- **chore:** Maintenance tasks (e.g., `chore: update dependencies`).
- **docs:** Documentation changes (e.g., `docs: update README`).
- **style:** Code formatting changes (e.g., `style: format code`).
- **refactor:** Code refactoring (e.g., `refactor: streamline user flow`).
- **perf:** Performance improvements (e.g., `perf: optimize dashboard load`).
- **test:** Adding or updating tests (e.g., `test: add unit tests for login`).
- **build:** Build system changes (e.g., `build: update webpack`).
- **ci:** CI configuration changes (e.g., `ci: add GitHub Actions`).
- **revert:** Reverting previous commits (e.g., `revert: revert commit abc1234`).
- **merge:** Merging branches (e.g., `merge: merge branch 'feature-branch'`).
- **hotfix:** Quick fixes for critical issues (e.g., `hotfix: correct typo`).

### Example Commit Messages

- `feat: add search functionality to navbar`
- `fix:

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-7.0

session

cookie