using System.Collections.Generic;

namespace CityLibraryApi.Models
{
    public class Reader
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public List<Book> Books { get; set; }
    }
}