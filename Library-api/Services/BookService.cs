using Library_api.DTO;
using Library_api.Entities;

namespace Library_api.Services
{
  
    
        public class BookService
        {
        public static List<Author> authors = new List<Author>();
        public static List<Book> books = new List<Book>();
        public int AddBook(int id, AddBookDto dto)
            {

                var author= authors.FirstOrDefault(_ => _.Id == id);
                var book = new Book
                {
                    Name = dto.Name,
                    Count = dto.Count,
                   
                    
                };
               books.Add(book);
               
                return book.Id;
            }
            public  List<Book> GetBook()
            {
            return books;

            }
            public void DeletBook(int id)
            {
                var delete = books.Where(_ => _.Id == id).First();
                books.Remove(delete);
            }
        }
   
}
