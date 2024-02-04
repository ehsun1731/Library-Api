﻿using Library_api.DTO;
using Library_api.Entities;
using Library_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library_api.Controllers
{
    [Controller]
    [Route("Api/Category")]
    public class CategoryController : Controller
    {
        private readonly CategoryService _service;
        public CategoryController()
        {
            _service = new CategoryService();
        }

        [HttpPost("add-category")]

        public int AddCategory([FromBody] AddCategoryDto dto)
        {
            return _service.AddCategory(dto);
        }
        [HttpGet("serch-Book")]
        public List<Book> SerchBook([FromRoute] string serche)
        {
            return _service.SerchCategory(serche);
        }
    }
}
