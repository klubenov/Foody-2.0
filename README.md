# Foody-2.0

The project follows standart ASP.NET MVC structure:

- all HTML (cshtml) files reside in /Foody.Web/Views with a common layout file - /Foody.Web/Views/Shared/_Layout.cshtml;

- all sccs files are in /Foody-2.0/Foody.Web/wwwroot/css/ and are included in /Foody-2.0/Foody.Web/wwwroot/css/site.scss which is passed to /Foody.Web/Views/Shared/_Layout.cshtml and precompiled to css at runtime by LigerShark.WebOptimizer.Sass;

- all scripts are included at the end of the CSHTML file they operate on in a Scripts section and are added to the layput page when the CSHTML file is rendered;

- the controllers are used purely for displaying the requested views, no backend logic is applied.
