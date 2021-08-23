using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_v1
{
    class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public DataTable GetCategory()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetServiceCategory ", new object[] { });
            return data;
        }
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "select * from ServiceCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }
        public DataTable GetAllCategory()
        {
            string query = "select * from ServiceCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "select * from ServiceCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }
    }
}
