CREATE THE MODEL CLASSES FIRST AND ENTITY FRAMEWORK CORE CREATES THE DATABASE
Step by step Create ASP.NET Core MVC Movie CRUD App
1) Create Controller with 2 methods:
 - IActionResult Index { return View(); }
 - IActionResult Welcome { return View(); }
 Every public method in a controller is callable as an HTTP Endpoint.
 Use Razor View files - cleanly encapsulate the process of generating HTML responses to Client
2) Create 2 Views: Index.cshtml; Welcome.cshtml
3) Passing Data from Controller to the View.
4) Add a Data Model class 
5) Scaffold the Movie Model -> produce pages for Create, Read, Update, Delete
- MVC Controller with Views using Entity Framework
- Visual Studio creates Database Context class
- A movies Controller
- Razor View files (CRUD)
6) Add an Initial Migration. Update database
- Database created (See on SQL Server Object Explorer)
7) Work with SQL
- MvcMovieContext object handles the task of connecting to database and mapping Movie objects 
to database records. The database context is registered with Dependency Injection Container.
8) Seed the database
- add a Model class SeedData. Create a method and use 'using' to connect to DB, then write
movies on it in form of objects.
- Modify the program class
9) Process the POST request.
 

 