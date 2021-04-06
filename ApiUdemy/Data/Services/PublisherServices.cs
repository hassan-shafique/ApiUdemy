using ApiUdemy.Data.Models;
using ApiUdemy.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUdemy.Data.Services
{
    public class PublisherServices
    {
        private ApplicationDbContext dbContext;
        public PublisherServices(ApplicationDbContext context)
        {
            dbContext = context;
        }
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Publisher_Name = publisher.Publisher_Name
            };
            dbContext.Publishers.Add(_publisher);
            dbContext.SaveChanges();
        }
    }
}
