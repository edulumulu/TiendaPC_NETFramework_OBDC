# TiendaPC - Aplicación de Venta de Componentes Informáticos

Este proyecto es una aplicación de escritorio desarrollada en Visual Studio (.NET Framework) que permite gestionar la venta de componentes informáticos. Incluye funcionalidades como filtrado de productos, gestión de carrito de compras, exportación e importación de pedidos, y generación de un informe PDF del catálogo.

## 🛠️ Características

- Filtrado avanzado del catálogo por categoría, precio, marca, etc.
- Gestión de carrito en ventana secundaria (modal).
- Menú y barra de herramientas con accesos rápidos e iconos.
- Exportación del pedido desde ambas ventanas.
- Informe PDF con catálogo ordenado por precio creciente y agrupado por categoría.

## 🗃️ Base de datos

### Archivo SQL

El script `tiendapc.sql` ubicado en la carpeta `Resources/` permite crear la base de datos necesaria para ejecutar la aplicación. Puedes usarlo en MySQL Workbench u otro sistema compatible.

### Requisitos de conexión

1. **Crear un alias ODBC llamado `tiendapc`**:
   - Usa el Administrador de Orígenes de Datos ODBC de Windows.
   - Selecciona el tipo de controlador correspondiente (MySQL, SQL Server, Access…).
   - Descarga el driver ODBC adecuado si no lo tienes instalado.
   - Configura la conexión con el nombre de alias `tiendapc`.
   - Introduce las credenciales necesarias (usuario y contraseña) dentro del alias.
   - ⚠️ **No guardes credenciales dentro del código de la aplicación.**

2. **Cadena de conexión utilizada en el código**:
Dsn=tiendapc


## 🚀 Cómo ejecutar

1. Clona o descarga este repositorio.
2. Abre la solución `TiendaPC.sln` en Visual Studio.
3. Asegúrate de tener instalado el controlador ODBC correspondiente (MySQL, Access, SQL Server…).
4. Abre MySQL Workbench (u otro SGBD) y ejecuta el script `Resources/tiendapc.sql` para crear la base de datos.
5. Crea un alias ODBC llamado `tiendapc` apuntando a esa base de datos.
6. Verifica que las credenciales estén correctamente configuradas en el alias.
7. Compila y ejecuta el proyecto desde Visual Studio.

## 📄 Informe PDF del Catálogo

- El informe se genera automáticamente desde el proyecto.
- Se puede exportar en formato PDF.
- Agrupa los productos por categoría.
- Ordena los productos por precio (de menor a mayor).
- Está diseñado para tener un buen aspecto impreso o en PDF.

---

📬 Si tienes dudas sobre cómo configurar el alias ODBC o ejecutar el script, puedes consultar [este video tutorial](https://www.youtube.com/watch?v=LGvbVwcuISQ).

---

📌 **Autor:** *edulumulu*
