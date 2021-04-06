using ApiUdemy.Data.Models;
using ApiUdemy.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUdemy.Data.Services
{
    public class AuthorServices
    {
        private ApplicationDbContext dbContext { get; set; }
        public AuthorServices(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                AuthorName = author.AuthorName
            };
            dbContext.Authors.Add(_author);
            dbContext.SaveChanges();
        }
    }
}
