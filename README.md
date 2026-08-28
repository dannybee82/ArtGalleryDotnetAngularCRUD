# ArtGalleryDotnetAngularCRUD

An Angular 22 application (with [Angular CLI](https://github.com/angular/angular-cli) version 22.1.6) that demonstrates the regular HttpClient with Observables.  
It uses a .NET/C# WebAPI as Backend and a PostgreSQL database.  
The .NET/C# WebAPI stores Paintings/images and thumbnails in the database as base64-strings.

The Angular application can fetch, filter, create, update and delete paintings, styles and artists.  
This application can upload images to the .NET/C# WebAPI with the use of IFormFile.  
Using the _SixLabors.ImageSharp library_, uploaded images are resized to thumbnails.

See the images in the root of this project for examples.

## Running the application

### _1\. Docker Desktop / Docker_

To see the application in action within a _Docker Container_, use the command from the root of this project:

**docker compose up --build -d**

To see also the (optional) _Cypress e2e tests_ in action within a _Docker Container_, use the command:

**docker compose --profile test up --exit-code-from cypress cypress**

### _2\. Local installation_

**A) PostgreSQL database:**

See in this project the folder: _Docker\_PostgreSQL_ with the docker-compose file for the PostgreSQL database.

Run the command command here below from the folder /_Docker\_PostgreSQL_

**docker-compose up --build -d**

**B) Add database migrations**

Install the **dotnet ef-tool** - version: 8.0.11 or above - see the url: [dotnet EF tool](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

When the tool is installed, run the command for a _database migration:_

**dotnet ef database update**

Or use the longer command (and replace: \*_YOUR\_WORKSPACE_\*):  
_dotnet ef database update -p_ \*_YOUR\_WORKSPACE_\*_/ArtGalleryDotnetAngularCRUD/Backend/RepositoryLayer/RepositoryLayer.csproj" --startup-project "_\*_YOUR\_WORKSPACE_\*_/ArtGalleryDotnetAngularCRUD/Backend/ArtGalleryWebApi/ArtGalleryWebApi.csproj"_

For more information see the link below:

[https://learn.microsoft.com/en-us/ef/core/cli/dotnet](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

**C) Angular application installation**

**Angular 22** needs a **Node.js** version of at least _22.22.3_

**Command to install**

_npm install_  
or shorter:

_npm i_

**Command to run the application:**

_ng serve --open_

or shorter:

_ng s --o_

**Command to run Cypress e2e (end-to-end) testing**  
_ng e2e_

## **Changelog:**

_August 2026_

**General changes:**

\- Dockerized the whole application and added a new _docker-compose.yml_ file for the whole application.

\- Optional run the _Cypress e2e tests_ in a Docker container.

**Backend changes:**

\- Replaced a custom method to get the file extension with: _Path.GetExtension()_.

**Frontend changes:**

\- Updated packages.

\- Removed package _ngx-toastr_ and replaced this with a custom Toastr.

_June 2026_

**Frontend changes:**

\- Upgrade to _Angular 22_ and upgraded other packages.

\- Migrated _@Injectable_ to _@Service_ (Except for 3 services).

\- Using the default: _ChangeDetectionStrategy.OnPush_ in stead of _ChangeDetectionStrategy.Eager_.

\- Using the latest file naming conventions - and deleting the old schematics from _angular.json_

\- Minor changes to _Cypress end-to-end (e2e)_ tests.

\- Removed deprecated _Cypress_ package _cypress-file-upload_ (now using native Cypress _selectFile()_ method).

**Backend changes:**

\- Added 5 new Works of Art.

\- Updated some packages.

\- Also allow the _.jpeg_ file extension.

_March 2026_

**Frontend changes:**

\- Upgraded packages for @angular/cli@21.2.0 and added _Prettier_.

\- Changed the text 'X paintings found' to 'X Works of Art' found' using the Angular I18nPluralPipe.

\- Update 1 Cypress test.

\- Justify text on details page.

\- Various minor changes in the HTML-templates.

\- Updated the imports of the specification files for _Vitest_ (for future use).

**Backend changes:**

\- Added 5 new works of art.

\- Upgraded some packages.

\- Changed the working of the available filters.

_December 2025_

**Frontend changes:**

\- Upgraded packages _@ngrx/store_ and _@ngrx/signals_ to version 21 (no _npm i --force_ needed anymore).

\- Upgraded other packages.

\- More responsiveness.

\- Delete dialog has English texts now.

_November 2025_

**Backend changes:**

\- Added 10 additional works of art.

\- Renamed files with dummy data.

\- Changed some texts.

\- Bugfix for updating a painting.

**Frontend changes:**

\- Upgrade to _Angular 21_ and upgraded other packages.

*   Removed deprecated _Karma_ and installed _Vitest._
*   Migrated _Jasmine_ tests to _Vitest_ tests for future use (command: **ng generate refactor-jasmine-vitest**).
*   HttpClient unchanged (makes use of an interceptor).

\- Use \[innerHTML\] on specific elements.

\- Changed layout of painting details page.

\- Using @defer for images on all paintings page.

\- Changed the _Cypress tests_ to the new situation.

\- Various other small changes.

_September 2025_

**Frontend changes:**

\- Added Cypress end-to-end testing.

\- Updated packages.

\- Various minor changes in templates + added data-cy attributes.

_August 2025_

**Backend changes:**

\- Added more works of art.

\- Updated package _SixLabors.ImageSharp_

**Frontend changes:**

\- Fixed some typing errors.

\- Moved the (collapsable) menu to the left side.

\- Updated packages.

\- Changed the scroller.

\- Added _NgRx signalStore_.

\- Moved a folder and various minor changes.

_July 2025_

**Backend changes:**

\- Added new works of Art. New migration for Database.

\- Added an Endpoint, Service and Repository that returns a paged list.

**Frontend changes:**

\- Upgrade to Angular 20.

\- Using the keyword **readonly** for properties initialized by Angular (input(), output(), model()).

\- Using the keyword **protected** for properties that are only accessible in the template.

\- Removed unnecessary package _@angular/platform-browser-dynamic_.

\- Changed to _Zoneless_ (no Zone.js).

\- Using _smooth_ scrolling for scroll to top.

\- Added Pager and Pagination.

\- Added a separate file for a shared constant.