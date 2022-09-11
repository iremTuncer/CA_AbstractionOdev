using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractionOdev
{
    public class Employee:BaseClass<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string Create(Employee model)
        {
            int id = 0;
            if (Container.employeesList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.employeesList.Count;
            }

            model.Id = id;
            Container.employeesList.Add(model);

            return "Kategori eklendi!";
        }

        public override string Delete(int id)
        {
            Employee deleted = GetById(id);
            Container.employeesList.Remove(deleted);
            return "Kategori silindi!";
        }

        public override Employee GetById(int id)
        {
            Employee employee = null;
            foreach (Employee employee1 in Container.employeesList.ToList())
            {
                if (employee1.Id == id)
                {
                    employee = employee1;
                    break;
                }
            }
            return employee;
        }

        public override List<Employee> GetList()
        {
            return Container.employeesList.ToList();
        }

        public override string Update(Employee model)
        {
            Employee updated = GetById(model.Id);
            updated.FirstName = model.FirstName;
            updated.LastName = model.LastName;
            updated.BirthDate = model.BirthDate;
            return "Kategori güncellendi!";

        }
    }
}
