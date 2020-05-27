using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController
    {
        List<Product> products = new List<Product>
        {
            new Product {Code = "014600301", Description = "BARILLA FARINA 1 KG", Price = 1.09 },
            new Product {Code = "013500121", Description = "BARILLA PASTA GR.500 N.70 1/2 PENNE", Price = 1.3 },
            new Product {Code = "007686402", Description = "FINDUS FIOR DI NASELLO 300 GR", Price = 6.46 },
            new Product {Code = "057549001", Description = "FINDUS CROCCOLE 400 GR", Price = 5.97 }
        };

        [HttpGet("all")]
        public List<Product> ListAllProducts()
        {
            return products;
        }

        [HttpGet("code/{codart}")]
        public List<Product> ListProductsByCode(string codart)
        {
            List<Product> selectedProduct = products.Where(product => product.Code == codart).ToList();
                return selectedProduct;
        }

        [HttpGet("description/{desc}")]
        public List<Product> ListProductsByDescription(string desc)
        {
            List<Product> selectedProduct = products.Where(product => product.Description.ToUpper().Contains(desc.ToUpper())).ToList();
                return selectedProduct;
        }
        [HttpPost("add")]
        public List<Product> addProducts([FromBody] Product prod)
        {
            Product newProduct = new Product {Code = prod.Code, Description = prod.Description, Price = prod.Price};
            products.Add(newProduct);
            return products;
        }
    }
}