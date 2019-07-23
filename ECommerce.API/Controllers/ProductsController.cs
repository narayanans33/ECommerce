﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<ApiProduct>> GetAsync()
        {
            return new[] { new ApiProduct { Id = Guid.NewGuid(), Name = "Prod Name", Description = "Some Description", Price = 12.1, IsAvailable = true } };
        }
            
        [HttpPost]
        public async Task PostAsync([FromBody] ApiProduct product)
        {

        }
    }
}
