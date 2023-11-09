# C# ASP.NET MVC Razor Style Guide

This repository is intended to serve as a guide for best practices when developing ASP.NET applications using [Clean Architecture](https://learn.microsoft.com/en-us/shows/dotnetconf-2021/clean-architecture-with-aspnet-core-6).

Project Structure:
```shell
/
├── API/
    ├── Controllers/
├── Domain/
    ├── Constants/
    ├── Entities/
    ├── Enums/
    ├── Exceptions/
├── App/
    ├── Example/
├── Infra/
    ├── Data/
└── Web/
    ├── Pages/
    ├── wwwroot/
└── Test/
    ├── Unit/
    └── Integration/
    └── EndToEnd/
```
This repo is split into multiple projects.

### Domain

This project contains all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### App

This project contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project.

### Infra

This project contains classes for accessing external resources such as file systems, web services, SMTP, and so on. These classes should implement interfaces defined within the application layer.

### Web

This is the entry point of the application. It's an ASP.NET Razor Pages project and depends on both the Application and Infrastructure layers. However, the dependency on Infrastructure is only to support dependency injection. Therefore, at runtime, this layer does not directly depend on Infrastructure.

## Projects

| Project          | Build                                              | Run                                               | Watch                                              |
| ---------------- | -------------------------------------------------- | ------------------------------------------------- | -------------------------------------------------- |
| API              | <pre>cd API<br>dotnet build<br></pre>              | <pre>cd API<br>dotnet run<br></pre>               | <pre>cd API<br>dotnet watch<br></pre>              |
| App              | <pre>cd App<br>dotnet build<br></pre>              | -                                                 | <pre>cd App<br>dotnet watch<br></pre>              |
| Domain           | <pre>cd Domain<br>dotnet build<br></pre>           | -                                                 | <pre>cd Domain<br>dotnet watch<br></pre>           |
| Infra            | <pre>cd Infra<br>dotnet build<br></pre>            | -                                                 | <pre>cd Infra<br>dotnet watch<br></pre>            |
| Web              | <pre>cd Web<br>dotnet build<br></pre>              | <pre>cd Web<br>dotnet run<br></pre>               | <pre>cd Web<br>dotnet watch<br></pre>              |
| Test.Unit        | <pre>cd Test/Unit<br>dotnet build<br></pre>        | <pre>cd Test/Unit<br>dotnet test<br></pre>        | <pre>cd Test/Unit<br>dotnet watch<br></pre>        |
| Test.Integration | <pre>cd Test/Integration<br>dotnet build<br></pre> | <pre>cd Test/Integration<br>dotnet test<br></pre> | <pre>cd Test/Integration<br>dotnet watch<br></pre> |
| Test.EndToEnd    | <pre>cd Test/EndToEnd<br>dotnet build<br></pre>    | <pre>cd Test/EndToEnd<br>dotnet test<br></pre>    | <pre>cd Test/EndToEnd<br>dotnet watch<br></pre>    |

### Testing

Generate code coverage:
```shell
cd Test
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov
```

Run playwright tests:
```shell
cd Test/PlaywrightTests
dotnet test -- NUnit.NumberOfTestWorkers=5
```

## Technologies

* ASP.NET 6.0
* Entity Framework 6
* Razor Pages
* XUnit
* Playwright

## Glossary

[Razor](./Docs/Razor.md)

[MVC](./Docs/MVC.md)

[Entity Framework](./Docs/EntityFramework.md)

- [ ] XUnit
- [ ] Playwright

## Resources

[Microsoft naming guidelines](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

[C# Coding Style](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md)

[Common C# code conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

[Google C# Style Guide](https://google.github.io/styleguide/csharp-style.html)

[Clean Code .NET](https://github.com/thangchung/clean-code-dotnet)
