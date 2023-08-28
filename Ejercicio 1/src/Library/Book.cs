using System;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
 
        /*        
        public string LibrarySector { get ; set; } --> El libro no debería tener la responsabilidad de saber en qué sector se encuentra.
        public string LibraryShelve { get ; set; } --> De la misma forma, el libro no tendría por qué saber su ubicación.
        */

        // Para esto creamos nuevas clases que sean expertas en esa información.
        // Por un lado, la clase Shelves va a tener la responsabilidad de conocer los libros que posee, que se traduce en un atributo.
        // Por otro, la calse Sector va a tener la responsabilidad de conocer las estanterías que posee.

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

    }
}
