using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractionOdev
{
    public class Customer : BaseClass<Customer>
    {
        public override string Create(Customer model)
        {
            int id = 0;
            if (Container.customersList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.customersList.Count;
            }

            model.Id = id;
            Container.customersList.Add(model);

            return "Kategori eklendi!";
        }

        public override string Delete(int id)
        {
            Customer deleted = GetById(id);
            Container.customersList.Remove(deleted);
            return "Kategori silindi!";
        }

        public override Customer GetById(int id)
        {
            Customer customer = null;
            foreach (Customer customer1 in Container.customersList.ToList())
            {
                if (customer1.Id == id)
                {
                    customer = customer1;
                    break;
                }
            }
            return customer;
        }

        public override List<Customer> GetList()
        {
            return Container.customersList.ToList();
        }

        public override string Update(Customer model)
        {
            Customer updated = GetById(model.Id);
            updated.CompanyName = model.CompanyName;
            updated.Phone = model.Phone;
            updated.Address = model.Address;
            return "Kategori güncellendi!";

        }
    }
}
