using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDB simüle eden,
            //Fake DB
            _products = new List<Product> { 
                new Product{ProductId=1, CategoryId=1, ProductName="Mouse", UnitPrice=150, UnitsInStock=20},
                new Product{ProductId=2, CategoryId=1, ProductName="Klavye", UnitPrice=250, UnitsInStock=35},
                new Product{ProductId=3, CategoryId=2, ProductName="Bardak", UnitPrice=30, UnitsInStock=60},
                new Product{ProductId=4, CategoryId=2, ProductName="Tabak", UnitPrice=50, UnitsInStock=50},
                new Product{ProductId=5, CategoryId=3, ProductName="Saat", UnitPrice=750, UnitsInStock=10},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ = Language Integrated Query
            //=>  Lambda işareti
            Product productToDelete = null;

            /*
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId) {
                    productToDelete = p;
                }
            }
            */
            //Yukarıdaki foreach kodu yerine LINQ kullanarak yazalım. 
            //SingleOrDefault() fonksiyonu içindeki her bir p için p'nin ProductId'si
            //product.ProductId' ye eşit mi kontrolü yapar.  

            productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return  _products.Where(p=> p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product) 
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki  ürün id'sini bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}