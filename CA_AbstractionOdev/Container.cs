using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractionOdev
{
    internal class Container
    {
        public static List<Product> productList = new List<Product>();
        public static List<Category> categoryList = new List<Category>();
        public static List<Supplier> suppliersList = new List<Supplier>();
        public static List<Employee> employeesList = new List<Employee>();
        public static List<Shipper> shippersList = new List<Shipper>();
        public static List<Customer> customersList = new List<Customer>();
    }
}
