using Library_api.DTO;
using Library_api.Entities;

namespace Library_api.Services
{
    public class UserService
    {
        public static List<User> users = new List<User>();
        public static List<Book> books = new List<Book>();
        public int AddUser(AddUserDto dto)
        {
            var user = new User
            {
                Name = dto.Name,
            };
            users.Add(user);
           
            return user.Id;
        }
        public void RentBook(string user, string book)
        {
            var buy = books.Where(_ => _.Name == book && _.Name == user).FirstOrDefault();
            buy.Count--;
            buy.RentBook++;
            buy.BookCount++;
            
        }
    }
}
