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

Cuando ya se han creado los proyectos, se agregan los proyectos a la solución. Se debe de estar ubicado a nivel de la solución (*cd ..*)

> dotnet sln add [Folder]/[NOMBRE_PROYECTO].csproj

    dotnet sln add serviceCode.API/serviceCode.API.csproj

Para agregar las referencias entre los projectos; nos ubicamos a nivel de la solución y aplicamos el comando

> dotnet add [FOLDER]/[PROYECTO].csproj reference [FOLDER]/[PROYECTO].csproj

    dotnet add serviceCode.API/serviceCode.API.csproj reference serviceCode.Domain/serviceCode.Domain.csproj