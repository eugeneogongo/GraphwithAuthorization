using GraphQLWithAuthorization.Data;
using GraphQLWithAuthorization.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWithAuthorization.Repositories
{
    public class ProductRepository
    {
        private readonly ProductContext context;

        public ProductRepository(ProductContext context)
        {
            this.context = context;
        }

        public Task<List<Product>> GetProducts()
        {
            return context.Products.ToListAsync();
        }

        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }


    }
}
