using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api")]
    public class ProductController : ApiController
    {
        public List<Product> Products
        {
            get
            {
                return new List<Product>()
                {
                    new Product() { Id = 1, Name = "Camera", Price = 150.0m },
                    new Product() { Id = 2, Name = "Onderbroeken", Price = 9.99m },
                    new Product() { Id = 3, Name = "Kettingslot", Price = 14.95m },
                    new Product() { Id = 4, Name = "Televisie", Price = 500.0m },
                };
            }
        }

        // GET api/products
        [Route("products")]
        public IEnumerable<Product> Get()
        {
            return Products;
        }

        // GET api/products/2
        [Route("products/{id}")]
        public Product Get(int id)
        {
            return Products.Where(x => x.Id == id).SingleOrDefault();
        }

        // POST api/products
        [Route("products")]
        public void Post([FromBody]Product product)
        {
        }

        // PUT api/products
        [Route("products")]
        public void Put([FromBody]Product product)
        {
        }

        // DELETE api/products
        [Route("products")]
        public void Delete(int id)
        {
        }
    }
}
