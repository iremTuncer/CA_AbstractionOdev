using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractionOdev
{
    public class Shipper : BaseClass<Shipper>
    {
        public override string Create(Shipper model)
        {
            int id = 0;
            if (Container.shippersList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.shippersList.Count;
            }

            model.Id = id;
            Container.shippersList.Add(model);

            return "Kategori eklendi!";
        }

        public override string Delete(int id)
        {
            Shipper deleted = GetById(id);
            Container.shippersList.Remove(deleted);
            return "Kategori silindi!";
        }

        public override Shipper GetById(int id)
        {
            Shipper shipper = null;
            foreach (Shipper shipper1 in Container.shippersList.ToList())
            {
                if (shipper1.Id == id)
                {
                    shipper = shipper1;
                    break;
                }
            }
            return shipper;
        }

        public override List<Shipper> GetList()
        {
            return Container.shippersList.ToList();
        }

        public override string Update(Shipper model)
        {
            Shipper updated = GetById(model.Id);
            updated.CompanyName = model.CompanyName;
            updated.Phone = model.Phone;
            return "Kategori güncellendi!";

        }
    }
}
