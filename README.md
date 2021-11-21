# Proyecto: Sistema de Inventario para Tienda de Sentimientos (SITS)

## Descripción:

 El objetivo del proyecto es desarrollar un software de aplicación de escritorio para control de inventario y realización de cotizaciones.

 Este proyecto nace con base en una necesidad personal siendo impulsada en la materia de desarrollo de software orientada a objetos de la univesidad, donde se nos enseñaron conceptos básicos de C# utilizando visual studio 2019.

La rama de desarrollo principal que se utiliza actualmente es [design_main](https://github.com/ivanfbj/Proyecto_SITS/tree/design_main), la rama [master](https://github.com/ivanfbj/Proyecto_SITS/tree/master) está pendiente por actualización.

El proyecto SITS es desarrollado por:  
 [Ivan](https://github.com/ivanfbj): Estudiante de Ingenieria en Sitemas. Enfocado en el Backend del proyecto  
 [Luisa](https://github.com/lfdaach): Estudiante de Tecnologia en Desarrollo de sistema de Información. Enfocada en el Frontend del proyecto con participación del Backend.

---
## Instalación:

1. Descargar o clonar el código por medio del enlace [https://github.com/ivanfbj/Proyecto_SITS.git](https://github.com/ivanfbj/Proyecto_SITS.git)
2. Abrir en proyecto en Visual Studio 2019, ir al Explorador de soluciones -> Referencias -> Clic derecho -> Agregar Referencia -> Seleccionar Microsoft.VisualBasic -> Aceptar. Esto se debe a que hay una funcionalidad que se implementó que requiere esta referencia activa.
3. La base de datos se implementada en Microsoft Sql server 2019, la información para crear tablas, crear procedimientos almacenados e insertar información básica se encuentran en la carpeta "Sentencias_para_base_de_datos", se deben ejecutar en el mismo orden en el que se encuentran enumerados los archivos.
4. Actualizar la conexión a la base de datos que se encuentra en el archivo **"clsConexionSql.cs"**
---
## Como usar:
- **Módulo Inventario**: Permite añadir los productos sobre los cuales se va a llevar el control de inventario.
- **Módulo Combos**: Permite agrupar los productos en los combos que se deseen crear.
- **Módulo Pedidos**: Permite seleccionar el combo previamente configurado, añadir productos adicionales para crear el pedido.

## Documentos:
En la carpeta llamadas "Documentos" se encuentra una lista en excel con algunas mejoras pendientes para incluirle al proyecto.
