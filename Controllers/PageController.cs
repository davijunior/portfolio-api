using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Portfolio_BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PageController : ControllerBase
    {

        private readonly ILogger<PageController> _logger;

        public PageController(ILogger<PageController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            Page page = new Page{
                Title = "Davi Junior",
                Text = "TESTE TESTE TESTE TESTE TESTE",
                LinkedIn = new Uri("http://linkedin.com"),
                GitHub = new Uri("http://linkedin.com"),
                AboutMe = new Uri("http://linkedin.com")
            };
            string page_serialized = JsonSerializer.Serialize(page);
            return page_serialized;
        }

        [HttpGet("{id}")]
        public int Get(int id){
            return id;
        }
    }
}
