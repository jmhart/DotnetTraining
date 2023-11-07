Here are the basic concepts of ASP.NET MVC:

* Model: The Model represents the application data and business rules. It's responsible for retrieving data and converting it into a meaningful concept for the view.

* View: The View is responsible for displaying the application's user interface (UI). It uses the model to bring data in a presentable format.

* Controller: The Controller handles the user's interaction with the View. It processes the input from the view and updates the model, which in turn updates the view.

* Routing: Routing is the mechanism by which URLs are mapped to controller actions. ASP.NET MVC uses a routing engine, which maps URLs to controller classes.

* Action Methods: Action methods are methods within a controller that respond to URL requests. An action method typically has a one-to-one mapping with user interactions.

* ViewBag, ViewData, and TempData: These are techniques to pass data from controller to view and between requests.

* Layout View: A layout view is a common site template where you can put common view elements like headers, footers, and navigation menus.

* Partial View: Partial views are used to encapsulate reusable parts of views, such as a header or footer, that can be shared between different views.

* ViewStart: The ViewStart file is a special view that contains code that is executed before the code in any other view. It's typically used to specify a common layout for all views in an application.

* Filters: Filters are custom classes that provide a way for adding pre-action and post-action behavior to controller action methods.

* Areas: Areas provide a way to partition a large application into smaller functional groupings, each with its own set of controllers, views, and models.

* Dependency Injection: Dependency Injection (DI) is a design pattern that allows us to eliminate hard-coded dependencies and make our applications loosely coupled, extendable, and maintainable.