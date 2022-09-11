using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractionOdev
{
    public class Product:BaseClass<Product>
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitInStock { get; set; }    

        public override string Create(Product model)
        {
            int id = 0;
            if (Container.productList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.productList.Count;
            }

            model.Id = id;
            Container.productList.Add(model);

            return "Kategori eklendi!";
        }

        public override string Delete(int id)
        {
            Product deleted = GetById(id);
            Container.productList.Remove(deleted);
            return "Kategori silindi!";
        }

        public override Product GetById(int id)
        {
            Product product = null;
            foreach (Product product1 in Container.productList.ToList())
            {
                if (product1.Id == id)
                {
                    product = product1;
                    break;
                }
            }
            return product;
        }

        public override List<Product> GetList()
        {
            return Container.productList.ToList();
        }

        public override string Update(Product model)
        {
            Product updated = GetById(model.Id);
            updated.ProductName = model.ProductName;
            updated.UnitPrice = model.UnitPrice;
            updated.UnitInStock = model.UnitInStock;
            return "Kategori güncellendi!";

        }
    }
}
