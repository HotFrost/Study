using Microsoft.Build.Framework;

namespace Books.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public Genre Category { get; set; }
        public string  Url { get; set; }
    }
}
