using Library_api.DTO;
using Library_api.Entities;
using Library_api.EntitiesMap;
using System.Collections;
using System.Collections.Generic;

namespace Library_api.Services
{
    public class AuthorService
    {

        private readonly EFDBContext _context;
        public AuthorService()
        {
            _context = new EFDBContext();
        }

        public void AddAuthor(AddAuthorDto dto)
        {

            var author = new Author
            {
                Name = dto.Name
            };

            _context.Authors.Add(author);
            _context.SaveChanges();

        }
        public List <GetAuthorDto> GetAuthors()
        {
            return Authors;
        }
        public void DeletAuthor(int id)
        {

            var delete = _context.Authors.Where(_ => _.Id == id).First();
            _context.Authors.Remove(delete);

        }
    }

}
