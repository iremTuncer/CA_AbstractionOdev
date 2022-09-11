using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_AbstractionOdev
{
    public class Category:BaseClass<Category>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string Create(Category model)
        {
            int id = 0;
            if (Container.categoryList.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Container.categoryList.Count;
            }

            model.Id = id;
            Container.categoryList.Add(model);

            return "Kategori eklendi!";
        }

        public override string Delete(int id)
        {
            Category deleted = GetById(id);
            Container.categoryList.Remove(deleted);
            return "Kategori silindi!";
        }

        public override Category GetById(int id)
        {
            Category category = null;
            foreach (Category category1 in Container.categoryList.ToList())
            {
                if (category1.Id == id)
                {
                    category = category1;
                    break;
                }
            }
            return category;
        }

        public override List<Category> GetList()
        {
            return Container.categoryList.ToList();
        }

        public override string Update(Category model)
        {
            Category updated = GetById(model.Id);
            updated.CategoryName = model.CategoryName;
            updated.Description = model.Description;
            return "Kategori güncellendi!";

        }
    }
}
