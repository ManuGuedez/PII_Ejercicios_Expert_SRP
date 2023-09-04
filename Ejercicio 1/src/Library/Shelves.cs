using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SRP;

namespace Library
{
    public class Shelves
    {
        private static double shelfNumber = 0;
        public List<Book> Books { get ; set; }

        public double ShelfNumber { get ; private set ; } 
        public Shelves(List<Book> books)
        {
            this.Books = books;
            ShelfNumber = shelfNumber;
            shelfNumber++;
        }

        public Shelves()
        {
            return ; 
        }
        public double Lenght()
        {
            return Books.Count;
        }

        public Book BookIndex(int indice)
        {
            return Books[indice];
        }
    }
}