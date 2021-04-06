using ApiUdemy.Data.Services;
using ApiUdemy.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private AuthorServices AuthorServices;
        public AuthorController(AuthorServices services)
        {
            AuthorServices = services;
        }
        [HttpPost("Add-Author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            AuthorServices.AddAuthor(author);
            return Ok();
        }
    }
}
