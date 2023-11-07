# C# ASP.NET MVC Razor Style Guide

This repo is designed to be a guide for best practices for developing ASP.NET applications using clean architecture.

Project Structure:

/
├── src/
│   ├── Domain/
│   ├── Application/
│   ├── Infrastructure/
│   └── WebUI/
└── tests/
    ├── UnitTests/
    └── IntegrationTests/

## Technologies

* ASP.NET 6.0
* Entity Framework 6
* Razor Pages
* XUnit
* Playwright

## Projects

### API
  ```shell
  cd API
  dotnet watch
  ```
  Open browser and go to: `https://localhost:<PORT>/swagger/index.html`


## Docs

[Razor](./Docs/Razor.md)

[MVC](./Docs/MVC.md)

[Entity Framework](./Docs/EntityFramework.md)

## Reference

