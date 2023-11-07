# Web

This is the entry point of the application. It's an ASP.NET Razor Pages project and depends on both the Application and Infrastructure layers. However, the dependency on Infrastructure is only to support dependency injection. Therefore, at runtime, this layer does not directly depend on Infrastructure.
