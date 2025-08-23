using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Product
    {
        
    }

    interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }

    class Customer
    {

    }

    interface ICustomerDal
    {
        List<Customer> GetAll();
        Customer Get(int id);
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
