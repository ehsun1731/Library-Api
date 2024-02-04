using Library_api.DTO;
using Library_api.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Library_api.Services
{
    public class AuthorService
    {
       
        public static List <Author>authors = new List<Author>();

        public void AddAuthor(AddAuthorDto dto)
        {

            var author = new Author
            {
                Name = dto.Name
            };

            authors.Add(author);
            
           
           
        }
        public List <Author> GetAuthors()
        {
            return authors;
        }
        public void DeletAuthor(int id)
        {

            var delete = authors.Where(_ => _.Id == id).First();
            authors.Remove(delete);

        }
    }

}
