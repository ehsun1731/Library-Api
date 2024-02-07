namespace Library_api.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int RentBook { get; set; }
        
        public Author Author { get; set; }
        public int AuthorID { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public HashSet<Category> Categories { get; set; }

    }
}
