# RepositoryPatternNet6
Repository Pattern in .Net 6.0.1 Proyecto de Prueba... con tecnologias Nuevas.

El Web API se puede textiar en swagger.

El patrón de repositorio en .NET Core
Entity Framework Core ya sirve como unidad de trabajo. 

El patrón de repositorio en .NET Core
Para la demostración, estoy creando una aplicación simple de 3 niveles que consiste en un controlador, servicios y repositorios. Los repositorios se inyectarán en los servicios utilizando la inyección de dependencia integrada. 

En el proyecto de datos, tengo mis modelos y repositorios. Creo un repositorio genérico que toma una clase y ofrece métodos como obtener, agregar o actualizar.

Implementando los Repositorios

Este repositorio se puede utilizar para la mayoría de las entidades. En caso de que uno de sus modelos necesite más funcionalidad, puede crear un repositorio concreto que herede de Repository. 

El último paso es dar de alta los repositorios genérico y concreto en la clase Startup.

La primera línea registra los atributos genéricos. Esto significa que si desea usarlo en el futuro con un nuevo modelo, no tiene que registrar nada más. La segunda y tercera línea registran la implementación.

Servicios de Implementación que utilizan los Repositorios
Implemento dos servicios. Cada servicio se inyecta un repositorio.  Dentro de los servicios, puede implementar cualquier lógica que necesite su aplicación. Implementé solo llamadas simples al repositorio, pero también podría tener cálculos complejos y varias llamadas al repositorio en un solo método.

Implementación del controlador para probar la aplicación
Para probar la aplicación, implementé un controlador realmente simple. Los controladores ofrecen para cada método de servicio un método de obtención sin parámetros y devuelven lo que haya devuelto el servicio. Cada controlador obtiene el servicio respectivo inyectado.

Cuando llama a la acción de creación de cliente, se debe devolver un objeto de cliente en JSON.

Usa la base de datos
Si desea utilizar una base de datos, debe agregar su cadena de conexión en el archivo appsettings.json. 

Conclusión
Esta solución utiliza el núcleo del marco de la entidad como unidad de trabajo e implementa un repositorio genérico que se puede usar para la mayoría de las operaciones. También mostré cómo implementar un repositorio específico, en caso de que el repositorio genérico no pueda cumplir con sus requisitos. 
