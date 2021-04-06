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
    public class PublisherController : ControllerBase
    {
        private PublisherServices publisherServices;
        public PublisherController(PublisherServices services)
        {
            publisherServices = services;
        }
        [HttpPost("add-Publisher")]
        public IActionResult addPublishers([FromBody] PublisherVM publisher)
        {
            publisherServices.AddPublisher(publisher);
            return Ok();
        }
    }
}
