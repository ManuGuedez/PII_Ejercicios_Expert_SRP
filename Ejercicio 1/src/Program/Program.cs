using System;
using System.Collections.Generic;
using System.Text;
using Library;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Book book3 = new Book("Libro3", "Autor3", "234-356");
            Book book4 = new Book("libro4", "Autor4", "003-312");
            Book book5 = new Book("Libro5", "Autor5", "004-323");
            
            List<Book> books1 = new List<Book> {book1, book2};
            Shelves shelf1 = new Shelves(books1);
            
            List<Book> books2 = new List<Book> {book3, book4, book5};
            Shelves shelf2 = new Shelves(books2);

            List<Shelves> shelvesSector1 = new List<Shelves> {shelf1, shelf2}; 
            Sector sector = new Sector("Sector1", shelvesSector1);

            StringBuilder text = new StringBuilder($"\nLIBROS SECTOR {sector.SectorName}:\n\n");

            List<Shelves> listShelves = sector.Shelves;
            Shelves currentShelf = new Shelves();

            for(int i = 0; i<listShelves.Count; i++)
            {
                text.Append($"En el estante {i+1} están los siguientes títulos:\n");
                currentShelf = listShelves[i];
                for(int j = 0; j<currentShelf.Lenght(); j++)
                {
                    text.Append($"\t>>> {currentShelf.BookIndex(j).Title}\n");
                }
                text.Append("\n");
            }
            Console.WriteLine(text.ToString());
        }
    }
}