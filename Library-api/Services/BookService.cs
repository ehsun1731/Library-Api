using Library_api.DTO;
using Library_api.Entities;
using Library_api.EntitiesMap;

namespace Library_api.Services
{
  
    
        public class BookService
        {
        private readonly EFDBContext _context;
        public BookService()
        {
            _context = new EFDBContext();
        }
            public int AddBook(int id, AddBookDto dto)
            {

                var author= _context.Authors.FirstOrDefault(_ => _.Id == id);
                var book = new Book
                {
                    Name = dto.Name,
                    Count = dto.Count,
                    AuthorID = author.Id,

                };
            _context.Books.Add(book);
            _context.SaveChanges();

            return book.Id;
            }
            public  List<Book> GetBook()
            {
            return books;

            }
            public void DeletBook(int id)
            {
                var delete = _context.Books.Where(_ => _.Id == id).First();
            _context.Books.Remove(delete);
            }
        }
   
}
