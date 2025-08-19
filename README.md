# Singleton WebAPI

Proyecto de ejemplo de una **Web API en C# (.NET 8)** que utiliza el **patrón Singleton** para la gestión de datos en memoria.
Este proyecto simula un servicio de base de datos sencillo para **almacenar, consultar y eliminar elementos**.  

---

## Funcionalidades

- **Agregar elementos** a la base de datos en memoria.  
- **Consultar elementos** existentes mediante un endpoint GET.  
- Uso del **patrón Singleton** para garantizar una única instancia del servicio de datos durante la ejecución de la API.  
- Integración con **Swagger** para probar los endpoints fácilmente.  

---

## Endpoints disponibles

| **Método** | **Ruta**        | **Descripción**                 |
|------------|----------------|---------------------------------|
| GET        | `/api/home`    | Obtiene todos los elementos     |
| POST       | `/api/home`    | Agrega un nuevo elemento        |

---

## Tecnologías

- **C#**  
- **.NET 8**  
- **ASP.NET Core Web API**  
- **Swagger/OpenAPI**  

---

## Instalación y uso

1. **Clonar el repositorio:**  
   ```bash
   git clone https://github.com/SabrinaLages/singleton-webapi.git
