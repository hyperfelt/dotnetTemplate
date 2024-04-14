# dotnetTemplate
A .NET 8+ universal template for building any app using a DDD-driven approach.

This template will generate all the necessary projects for building your app, dispatched in 3 solution folders representing the layers : "Domain", "Infrastructure" and "Presentation". A console project with a Dockerfile will be created in the "Presentation" layer by default, but you can of course create any presentation-type project here (web, API, desktop, mobile, etc.) and add references to all projects in the other layers.