# Aplicación CRUD de Empleados

Este es un proyecto web desarrollado con ASP.NET Core Razor Pages 3.1 que permite realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) sobre empleados.

## Características principales:
- Modelo Employee con campos: Nombre, Correo, Área, Fecha de Ingreso, Activo
- Validaciones con DataAnnotations
- Base de datos SQL Server LocalDB
- Patrón Repository para acceso a datos
- Vista reutilizable mediante ViewComponent que muestra totales de empleados activos e inactivos
- Diseño limpio y responsivo con Bootstrap
- Filtro y ordenamiento en el listado de empleados
- Validación de fecha (no puede ser mayor a hoy)

## Requisitos del sistema:
- .NET SDK 3.1 o superior
- Visual Studio (recomendado) o Visual Studio Code + herramientas de .NET
- SQL Server Express LocalDB instalado

## Cómo ejecutar el proyecto:

1. Clona el repositorio:
   git clone https://github.com/tu-usuario/EmployeesCRUD.git 
   cd EmployeesCRUD

2. Restaura dependencias:
   dotnet restore

3. Compila y ejecuta:
   dotnet build
   dotnet run

La aplicación se ejecutará en:
https://localhost:5001

## Migraciones de la base de datos:

Asegúrate de tener la cadena de conexión correcta en appsettings.json:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EmployeesCRUDDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}

Ejecuta estos comandos para crear la base de datos:
dotnet ef migrations add InitialCreate
dotnet ef database update

## Estructura del Proyecto:
Models/Employee.cs
Data/ApplicationDbContext.cs
Repositories/IEmployeeRepository.cs + EmployeeRepository.cs
ViewComponents/EmployeeStatsViewComponent.cs
Pages/Employees/Index Create Edit Delete
wwwroot/ CSS JS imágenes
appsettings.json
README.md

## Características técnicas:
Validación de correo con [EmailAddress]
Validación de fecha no futura
Uso del patrón Repository
ViewComponent para estadísticas
Filtro y ordenamiento en el listado
Diseño con Bootstrap

## Licencia:
MIT License – ver LICENSE para más información.