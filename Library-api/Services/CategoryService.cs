using Library_api.DTO;
using Library_api.Entities;
using Library_api.EntitiesMap;

namespace Library_api.Services
{
    public class CategoryService
    {
        public readonly EFDBContext _context;
        public CategoryService()
        {
            _context= new EFDBContext();
        }
        public void AddCategory(int a, AddCategoryDto dto)
        {
            var book = _context.Books.FirstOrDefault(_ => _.Id == a);
            var category = new Category()
            {
                Name = dto.Name,
                BookId = book.Id

            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
        public List<Book> SerchCategory(string Serch)
        {
            var book = _context.Books.Where(_ => _.Name.Contains(Serch));
            return book.ToList();

        }
    }
}
