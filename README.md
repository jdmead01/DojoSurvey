# DojoSurvey

***Steps to take to Create Project***

// create directory. Within file create the project:

```terminal
dotnet dotnet new web --no-https -o <ProjectName>
```
// Create the following folders in your project manually

* **Views** (_what the client sees_)
  * Index.cshtml
  * Result.cshtml
* **Controllers** (_Routing_)
  * HelloController.cs
* **wwwroot** (_static files_)
  * CSS
    * style.css
  * Img

**Startup.cs**

* [ ] Add: services.AddMvc(); (_Line 18 of VS Code file_)
* [ ] Add: app.UseMvc(); (_Line 29 of VS Code file_)