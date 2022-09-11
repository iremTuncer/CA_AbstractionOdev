using System;
using System.Collections.Generic;

namespace CA_AbstractionOdev
{
     class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                ProductName = "Havlu",
                UnitPrice = 50,
                UnitInStock = 200
            };
            string result = product1.Create(product1);

            foreach(Product product in Container.productList)
            {
                Console.WriteLine($"Ürün adı:{product.ProductName} Fiyat:{product.UnitPrice} Stok:{product.UnitInStock}");
            }


            Category category1 = new Category()
            {
                CategoryName = "Tekstil",
                Description = "Bebek havlusu"
            };
            
            string result2 = category1.Create(category1);

            foreach (Category category in Container.categoryList)
            {
                Console.WriteLine($"Kategori adı:{category.CategoryName} Açıklama: {category.Description}");
            }

            Supplier supplier1 = new Supplier()
            {
                CompanyName = "Kidboo",
                Address = "Denizli"
            };
            string result3 = supplier1.Create(supplier1);
            foreach(Supplier supplier in Container.suppliersList)
            {
                Console.WriteLine($"Şirket adı:{supplier.CompanyName} Adres:{supplier.Address}");
            }

            Employee employee1 = new Employee()
            {
                FirstName = "Ahmet",
                LastName = "Sağlam"
            };
            string result4 = employee1.Create(employee1);
            foreach(Employee employee in Container.employeesList)
            {
                Console.WriteLine($"Çalışan adı:{employee.FirstName} Soyad:{employee.LastName}");
            }

            Customer customer1 = new Customer()
            {
                CompanyName = "Caploonba Bebe",
                Address = "İstanbul"
            };
            string result5 = customer1.Create(customer1);
            foreach(Customer customer in Container.customersList)
            {
                Console.WriteLine($"Şirket adı:{customer.CompanyName} Adres:{customer.Address}");
            }

            

            




        }
    }
}
