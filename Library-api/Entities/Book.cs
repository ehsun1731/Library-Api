namespace Library_api.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int RentBook { get; set; }
        public int BookCount { get; internal set; }
    }
}
