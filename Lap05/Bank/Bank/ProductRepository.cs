using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bank.Models;
using Bank.Repository;

namespace Bank
{
    public class ProductRepository
    {
        public Product PostProductDetails(Product ProductModel)
        {
            DbHelper dbInstance = new DbHelper();
            return dbInstance.CreateProduct(ProductModel);
        }
    }
}