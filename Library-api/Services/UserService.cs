using Library_api.DTO;
using Library_api.Entities;
using Library_api.EntitiesMap;
using System.Net;

namespace Library_api.Services
{
    public class UserService
    {
        public readonly EFDBContext _context;
        public UserService()
        {
            _context = new EFDBContext();
        }
        public void AddUser(AddUserDto dto)
        {
            var user = new User
            {
                Name = dto.Name,
            };
            _context.Users.Add(user);
            _context.SaveChanges();

           
        }
        public void RentBook(int BookId, int UserId)
        {
            var buybook = _context.Books.FirstOrDefault(_ => _.Id == BookId);
            var userbook = _context.Users.FirstOrDefault(_ => _.Id == UserId);
            buybook.UserId = UserId;
            buybook.Count--;
            buybook.RentBook++;

            userbook.BookCount++;
            _context.SaveChanges();

        }
    }

}
