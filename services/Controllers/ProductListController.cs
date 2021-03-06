using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend_service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductListController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Samsung Note 2", 
            "Mi 10", 
            "Samsung A90",
            "Samsung S20",
            "Samsung S20 FE",
            "Samsung S21", 
            "Samsung S21+",
            "Samsung S21 Ultra",
            "Apple iPhone 11",
            "Apple iPhone 11 Pro",
            "Apple iPhone 12 Mini", 
            "Apple iPhone 12", 
            "Apple iPhone 12 Pro", 
            "Apple iPhone 12 Pro Max", 
        };

        private readonly ILogger<ProductListController> _logger;

        public ProductListController(ILogger<ProductListController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ProductList> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, 14).Select(index => new ProductList
            {
                AddedAt = DateTime.Now.AddDays(index),
                PriceInDollar = rng.Next(250, 999),
                ProductDescription = Summaries[index]
            })
            .ToArray();
        }
    }
}
