using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.CategoriesUseCase;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {

        private List<Product> products;

        public ProductInMemoryRepository()
        {
            // Init with default values

            products = new List<Product>()
            {
                new Product { ProductId=1, CategoryId=2,Name="Iced Tea", Quantity=100, Price=1.99},
                 new Product { ProductId=2, CategoryId=2,Name="Cake", Quantity=50, Price=23.0},
                  new Product { ProductId=3, CategoryId=2,Name="Cool Drinks", Quantity=21, Price=32.99},
                   new Product { ProductId=4, CategoryId=3,Name="Tomato", Quantity=67, Price=8.90},
                    new Product { ProductId=5, CategoryId=3,Name="Beans", Quantity=323, Price=54.09},
                  new Product { ProductId=6, CategoryId=1,Name="Chocklet", Quantity=100, Price=45.0}

            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.CategoryId);
                product.CategoryId = maxId + 1;
                products.Add(product);
            }
            else
            {
                product.CategoryId = 1;
            }

        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
           var productToUpdate = GetProductById(product.ProductId);   
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
              
            }
        }

        public Product GetProductById(int productId)
        {
            return products.FirstOrDefault(x => x.ProductId == productId);
        }
    }
}
