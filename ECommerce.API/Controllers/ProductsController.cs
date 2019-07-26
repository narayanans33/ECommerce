using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.API.Model;
using ECommerce.ProductCatalog.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Client;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Microsoft.ServiceFabric.Services.Remoting.V2.FabricTransport.Client;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductCatalogService _service;

        ProductsController()
        {
            var proxyFactory = new ServiceProxyFactory(
                    c => new FabricTransportServiceRemotingClientFactory());

            _service = proxyFactory.CreateNonIServiceProxy<IProductCatalogService>(
                                new Uri("fabric:/ECommerce/ECommerce.ProductCatalog"),
                                new ServicePartitionKey(0));
        }

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
