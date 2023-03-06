# MagicApi

Pasos para ejecutar la Api

1- Cambiar la informacion del ConectionString con la informacion de tu maquina (Archivo ApiMagic\appsettings.json)
2- Seleccionar Restaurar paquetes nugets en la solucion(Opcional)

Migraciones Visual Studio
3- Abrir la seccion de Herramientas
4- Posicionar el mouse sobre Administrador de Paquetes Nuget
5- Luego seleccionar Consola del Administrador de Paquetes
6- En la consola seleccionar el Proyecto predeterminado DataAccess
7- Correr el comando update-database

Migraciones CLI
3- Sobre el proyecto DataAccess correr el comando dotnet ef database update

4- Ejecutar el proyecto
