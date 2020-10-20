using Bank.Models;
using Bank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Bank.Controllers
{
    public class ProductController : ApiController
    {
        private readonly BankContext _context = new BankContext();
        // GET: Product
        [HttpPost]
        [Route("api/Product/Create")]
        public string PostProductDetail(Product productModel)
        {
            DbHelper dbHelper = new DbHelper();
            productModel = dbHelper.CreateProduct(productModel);
            return "Success";
        }

       
        [HttpPut]
        [Route("api/Product/Update")]
        public IHttpActionResult Update(Product productModel)
        {
            var product = new Product()
            {
                Id = productModel.Id,
                Name = productModel.Name,
                qty = productModel.qty,
                Price = productModel.Price,
            };
            _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpDelete]
        [Route("api/Product/Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var product = _context.Products.SingleOrDefault(e => e.Id == id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok("Success");
        }
    }
}