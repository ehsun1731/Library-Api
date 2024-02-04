using Library_api.DTO;
using Library_api.Entities;
using Library_api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Library_api.Controllers
{
    [ApiController]
    [Route("Api/Author")]
    public class AuthorController : Controller
    {
        private readonly AuthorService _service;
        public AuthorController()
        {
            _service = new AuthorService();

        }

        [HttpPost("Add-Author")]
        public int AddAuthor([FromQuery] AddAuthorDto dto)
        {
            return AddAuthor(dto);

        }
        [HttpGet("Get-Author")]
        public Author GetAuthors()
        {
            return GetAuthors();
        }
        [HttpDelete("delete-Author")]
        public void DeleteAuthor([FromRoute] int i)
        {
            _service.DeletAuthor(i);
        }





    }

}
