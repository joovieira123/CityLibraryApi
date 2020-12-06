namespace CityLibraryApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool CheckedOut { get; set; }
        
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }
    }
}