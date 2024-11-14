PersonasApp
Aplicación ASP.NET Core MVC para gestionar personas con operaciones CRUD y un servicio REST para consultas.

Instalación
Clonar repositorio
Configurar la cadena de conexión en appsettings.json
usada: "Server=localhost\\SQLEXPRESS;Database=PersonasDb;Trusted_Connection=True;"

Crear la base de datos: 
```bash dotnet ef database update

Endpoints
Formulario: /Personas/Create
API REST: /api/PersonasApi/{nombres}

Base de datos

El script de creación de la base de datos está incluido en el archivo `PersonasDB_Script.sql`. Puedes ejecutar este script en tu servidor de base de datos SQL Server para crear las tablas necesarias. 
