# 27-06-2024-Full-Stack-Bootcamp-First-Backend-Project
🦋ASP.NET Core, a framework for developing web applications and services, is a redesigned version of ASP.NET MVC and ASP.NET Web API, combining them into a single programming model.
The main features of ASP.NET Core are as follows:
🍀 Open source and free.
🍀 While ASP.NET can develop Windows-based web applications, ASP.NET Core is compatible with all platforms such as Windows, macOS, and Linux, thus providing cross-platform support.
🍀 ASP.NET Core offers modular components through NuGet packages. Developers can make applications lightweight and optimized by adding only the components they need to the project file. For example, the Microsoft.AspNetCore.Mvc package provides MVC support. This enables the development of lighter and more performant applications.
🍀 Scalability is one of the strengths of ASP.NET Core. ASP.NET Core's modular, lightweight, high-performance structure, horizontal and vertical scalability solutions, and support for microservices and serverless architectures ensure that applications can meet increasing workloads and user demands. This is a critical feature for modern cloud-based applications

🦋MVC or Model-View-Controller is an architectural pattern or design pattern.
🍀Model: In MVC architecture, the model layer is where the data is kept, access to the database is provided, and all data operations are performed.
🍀View: View is the visualized version of the Model layer, where the user sees the application.
🍀Controller: It performs the operations between the Model and View layers.

🍀Program.cs file: This is the page with the first commands executed before the program is opened. It contains the necessary code to configure and run the application.
🍀Shared file: This folder contains components such as layout, partial views, and view components that can be used repeatedly in different parts of the application. This structure avoids code duplication and makes the application easier to maintain.
🍀wwwroot folder: This is where static files (HTML, CSS, JavaScript, images, etc.) are stored. Files that we don't want to take up space on the server but we want the user to see.
🍀TagHelper
  <a asp-controller="Bootcamp" asp-action="Details" asp-route-id = "@Model.Id">

🦋Repository Design Pattern: It is a structural design pattern that acts as an intermediary between the data source and the application. The Repository design pattern contains the methods required to perform CRUD (Create, Read, Update, Delete) operations on the data source.
🦋Constructor Method: It is used to set the initial state of the object and assign the required initial values. It has the same name as the class name and has no return type.
🦋Razor Syntax: Using Html and C# codes together in MVC projects is called Razor Syntax.
