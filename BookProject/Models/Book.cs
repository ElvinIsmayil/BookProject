namespace BookProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublicationYear { get; set; }

        public Book(string name, string author, DateTime publicationYear )
        {
            Name = name;
            Author = author;
            PublicationYear = publicationYear;
        }


    }
}
