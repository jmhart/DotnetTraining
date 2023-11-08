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

## Technologies

* ASP.NET 6.0
* Entity Framework 6
* Razor Pages
* XUnit
* Playwright

## Docs

[Razor](./Docs/Razor.md)

[MVC](./Docs/MVC.md)

[Entity Framework](./Docs/EntityFramework.md)

- [ ] XUnit
- [ ] Playwright

## Resources
- [ ] Add additional resources here for deeper learning.
