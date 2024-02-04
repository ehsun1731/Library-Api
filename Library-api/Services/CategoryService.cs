using Library_api.DTO;
using Library_api.Entities;

namespace Library_api.Services
{
    public class CategoryService
    {
        public static List<Category> categories = new List<Category>();
        public static List<Book> books = new List<Book>();
        public int AddCategory(AddCategoryDto dto)
        {

            var category = new Category()
            {
                Name = dto.Name,

            };
            categories.Add(category);
            
            return category.Id;
        }
        public List<Book> SerchCategory(string Serch)
        {
            var book = books.Where(_ => _.Name.Contains(Serch));
            return book.ToList();

        }
    }
}
