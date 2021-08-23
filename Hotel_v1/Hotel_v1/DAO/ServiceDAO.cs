using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel_v1
{
    class ServiceDAO
    {
        Data_Base mydb = new Data_Base();
        private static ServiceDAO instance;

        public static ServiceDAO Instance
        {
            get { if (instance == null) instance = new ServiceDAO(); return ServiceDAO.instance; }
            private set { ServiceDAO.instance = value; }
        }

        private ServiceDAO() { }
        public DataTable GetService()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetService", new object[] { });
            return data;
        }
        public DataTable GetServiceID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetServiceDetail @id", new object[] { id });
            return data;
        }
        public DataTable GetArchieve()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetArchive ", new object[] { });
            return data;
        }
        public void InsertService(string name, int idcategory, float price,int amount)
        {
            DataProvider.Instance.ExecuteQuery("USP_InsertService @name , @idCategory , @price , @amount", new object[] { name, idcategory, price ,amount});
        }
        public void UpdateService(int id,string name,int idcategory ,float price)
        {
            DataProvider.Instance.ExecuteQuery("USP_UpdateService @id , @name , @idcategory , @price ", new object[] { id, name , idcategory ,price });
        }
        public bool DeleteService(int idService)
        {
            BillInfoDAO.Instance.DeleteBillInfoByServiceID(idService);

            string query = string.Format("Delete Service where id = {0}", idService);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<Service> GetServiceByCategoryID(int id)
        {
            List<Service> list = new List<Service>();

            string query = "select * from Service where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }

            return list;
        }
        public DataTable GetServiceByCategory(int id)
        {
            string query = "select * from Service where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetArchiveByIDCategory(int idcategory)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetArchiveByIDCategory  @idcategory ", new object[] { idcategory });
            return data;
        }

      
        public List<Service> GetListService()
        {
            List<Service> list = new List<Service>();

            string query = "select * from Service";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Service Service = new Service(item);
                list.Add(Service);
            }

            return list;
        }

        public List<Service> SearchServiceByName(string name)
        {

            List<Service> list = new List<Service>();

            string query = string.Format("SELECT * FROM dbo.Service WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }

            return list;
        }
        public bool incAmount(int id, int amount)
        {
            SqlCommand command = new SqlCommand("UPDATE Service SET count =count+@amount WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public bool decAmount(int id, int amount)
        {
            SqlCommand command = new SqlCommand("UPDATE Service SET count = count-@amount WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

    }
}
