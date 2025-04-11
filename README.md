# ArtGalleryDotnetAngularCRUD

An Angular 19.2 application that demonstrates the regular HttpClient with Observables.  
It uses a .NET/C# WebAPI as Backend and a PostgreSQL database.  
The .NET/C# WebAPI stores Paintings/images and thumbnails in the database as base64-strings.

The Angular application can fetch, filter, create, update and delete paintings, styles and artists.  
This application can upload images to the .NET/C# WebAPI with the use of IFormFile.  
Using the _SixLabors.ImageSharp library_, uploaded images are resized to thumbnails.  
See the images in the root of this project for examples.

### **PostgreSQL database:**

See the folder: _Docker\_PostgreSQL_ with the docker-compose file.

Command to add the _docker container_:

**docker-compose up --build -d**

### **Add database migrations**

Install the **dotnet ef-tool** - version: 8.0.11 or above

When the tool is installed, run the command for a _database migration:_

**dotnet ef database update**

For more information see the link below:

[https://learn.microsoft.com/en-us/ef/core/cli/dotnet](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

### **Angular application installation**

**Command to install**

_npm install_

or shorter:

_npm i_

**Command to run the application:**

_ng serve --open_

or shorter:

_ng s --o_