# README 


sdsadsdsdsds


----
### Comandos

Crear solucion:
> dotnet new sln --name <font color="red">NOMBRE</font>

Crear Proyectos:
* Web API

        > dotnet new webapi --name NOMBRE

* Class Library

        > dotnet new classlib --name NOMBRE

* Unit test (**xUnit**)

        >dotnet new xunit --name NOMBRE


-----

### Referencias

Cuando ya se han creado los proyectos, se agregan los proyectos a la solución. Se debe de estar ubicado a nivel de la solución (*cd ..*)

> dotnet sln add [Folder]/[NOMBRE_PROYECTO].csproj

    dotnet sln add serviceCode.API/serviceCode.API.csproj

Para agregar las referencias entre los projectos; nos ubicamos a nivel de la solución y aplicamos el comando

> dotnet add [FOLDER]/[PROYECTO].csproj reference [FOLDER]/[PROYECTO].csproj

    dotnet add serviceCode.API/serviceCode.API.csproj reference serviceCode.Domain/serviceCode.Domain.csproj

----

### Packages

estando en la carpeta del proyecto

**Project Application**:
* dotnet add package Microsoft.Extensions.DependencyInjection >> nameSpace: Microsoft.Extensions.DependencyInjection;

* dotnet add package Microsoft.Extensions.Configuration >> nameSpace:

* dotnet add package Microsoft.Extensions.Options >> nameSpace: Microsoft.Extensions.Options

* dotnet add package Microsoft.Extensions.Configuration.Binder >>

dotnet add package Microsoft.Extensions.Configuration.Abstractions

--Configure<object>(configuration.GetSection(""))
dotnet add package Microsoft.Extensions.Options.ConfigurationExtensions