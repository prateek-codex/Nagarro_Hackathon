using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommercePortal.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            IList<Product> productList = null;

            using(var dbContext = new FlickCartEntities())
            {
                productList = dbContext.Products.ToList();
            }

            return productList;
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            Product product = null;
            using (var dbContext = new FlickCartEntities())
            {
                product = dbContext.Products.Find(id);
            }

            return product;
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
