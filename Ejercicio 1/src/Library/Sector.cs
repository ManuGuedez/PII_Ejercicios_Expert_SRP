using System.Collections.Generic;

namespace Library
{
    public class Sector
    {
        public string SectorName { get ; set ;}
        public List<Shelves> Shelves { get ; set ; }
        public Sector(string name, List<Shelves> shelves)
        {
            SectorName = name;
            Shelves = shelves;
        }
    }
}