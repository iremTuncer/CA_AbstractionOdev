using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractionOdev
{
    public abstract class BaseClass<T>
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public abstract string Create(T model);
        public abstract string Update(T model);
        public abstract string Delete(int id);
        public abstract T GetById(int id);
        public abstract List<T> GetList();
    }
}
