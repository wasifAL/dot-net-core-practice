using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dot_net_core_practice_demo.Repositories;
using dot_net_core_practice_demo.Entities;

namespace dot_net_core_practice_demo.Controllers
{
    [ApiController]
    [Route("item")]
    public class ItemController : ControllerBase
    {
        private readonly InMemItemRepositories repository;

        public ItemController()
        {
            repository = new InMemItemRepositories();
        }
                       
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }
    }
   

    
}
