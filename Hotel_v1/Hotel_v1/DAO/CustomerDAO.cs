using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_v1
{
    class CustomerDAO
    {
        private static CustomerDAO instance;
        Data_Base mydb = new Data_Base();

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }
        public void InsertCustomerCheckIn(int idroom,int idbill, string fname, string lname, string cmnd, string sex, string phone, string address, MemoryStream picture , DateTime datecheckin,int status )
        {
            DataProvider.Instance.ExecuteQuery("USP_InsertCustomerCheckIn  @idroom , @idbill , @fname , @lname , @cmnd , @sex , @phone , @address , @picture , @datecheckin , @status ", new object[] { idroom,idbill,fname,lname,cmnd,sex,phone,address,picture,datecheckin,0 });
        }
      
        public void checkoutCustomer(int idroom ,DateTime datecheckout,int status )
        {
            DataProvider.Instance.ExecuteQuery("USP_InsertCustomerCheckOut @idroom , @datecheckout , @status ",new object[] { idroom, datecheckout ,status});
        }
        public DataTable GetCustomerByRoom(int idroom)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCustomerByRoom @idroom  ", new object[] { idroom });
            return data;
        }
        public DataTable GetCustomer(int idroom )
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetCustomer @idroom ", new object[] { idroom });
            return data;
        }
        public DataTable GetAllCustomer()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAllCustomer ", new object[] { });
            return data;
        }
        public DataTable search(string key)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT RoomService.name as Room,Fname as [First Name],Lname as [ Last Name ],CMND,Sex,Phone,Address,DateCheckIn,DateCheckOut " +
                                    "FROM Customer inner join RoomService on Customer.IDRoom = RoomService.id " +
                                    "WHERE CONCAT(Fname, Lname, Address, Phone, CMND) LIKE '%" +key+"%'";
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }

}
