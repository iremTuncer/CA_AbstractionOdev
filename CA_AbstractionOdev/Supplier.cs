using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractionOdev
{
    public class Supplier : BaseClass<Supplier>
    {
        public override string Create(Supplier model)
        {
            int id = 0;
            if (Container.suppliersList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.suppliersList.Count;
            }

            model.Id = id;
            Container.suppliersList.Add(model);

            return "Kategori eklendi!";
        }

        public override string Delete(int id)
        {
            Supplier deleted = GetById(id);
            Container.suppliersList.Remove(deleted);
            return "Kategori silindi!";
        }

        public override Supplier GetById(int id)
        {
            Supplier supplier = null;
            foreach (Supplier supplier1 in Container.suppliersList.ToList())
            {
                if (supplier1.Id == id)
                {
                    supplier = supplier1;
                    break;
                }
            }
            return supplier;
        }

        public override List<Supplier> GetList()
        {
            return Container.suppliersList.ToList();
        }

        public override string Update(Supplier model)
        {
            Supplier updated = GetById(model.Id);
            updated.CompanyName = model.CompanyName;
            updated.Address = model.Address;
            return "Kategori güncellendi!";

        }
    }
}
