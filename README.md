
# ToDo App      

Esta es un sistema de gestion de tareas, en la que se utiliza el modelo vista controlador para gestionar la obtencion, creacion, actualizacion y eliminacion de las tareas

#### Tabla De La Base De Datos y Tipos de Datos

| ID | Titulo | Descripcion | Estado | Prioridad |
| --- | ------ | ----------- | ------ | --------- |
| INT | VARCHAR | VARCHAR | INT(Modelo ENUM) | INT (Modelo ENUM) |

### NuGet utilizados

- [EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/9.0.1?_src=template) version -- 9.0.1
- [CodeGeneration.Design](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/8.0.7?_src=template) -- version 8.0.7
-  [PostgreSQL](https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/9.0.3?_src=template) -- Version 9.0.3




## Ejecucion

El sistema trabaja con una conexion a SUPABASE, por lo que en el archivo 


```bash
   -AppSettings.Json
```
en la cadena de conexion se encontrara una cadena default, cambiala por tu cadena de conexión publica de supabase  


```csharp
//ejemplo de Cadena
{
  "ConnectionStrings": {
    "DefaultConnection": "User Id=[USER];Password=[YOUR-PASSWORD];Server=[HOST];Port=[PORT];Database=[DATABASE]"
  }
}
```
Puedes adaptar el *ConnectionStrings* para trabajar con SQL Server y no con SUPABASE, asegura instalar el NuGet para SQL y configurar el **builder.Services** 
    

NOTA: utiliza un gestor de variables de entorno para no exponer tus KEYS, la cadena de conexion en el codigo esta expuesto para fines de entendimiento del codigo.

