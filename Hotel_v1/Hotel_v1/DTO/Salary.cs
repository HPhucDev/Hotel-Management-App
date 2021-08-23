using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Hotel_v1
{
    class Salary
    {
        Data_Base mydb = new Data_Base();
        public bool InsertID(int UserID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "INSERT INTO Salary(UserID)" + "VALUES (@UserID)";
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
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
        public bool CheckOut(int UserID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "UPDATE Salary SET Checked=@one,CheckOut=GETDATE() WHERE UserID =@UserID AND Checked=@zero";
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
            command.Parameters.Add("@zero", SqlDbType.Int).Value = 0;
            command.Parameters.Add("@one", SqlDbType.Int).Value = 1;
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
        public bool CheckIn(int UserID)
        {
            //if (FindID(UserID) == true)
            //{
            //    return true;
            //}
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT * FROM Salary WHERE UserID =@UserID AND Checked=@zero";
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
            command.Parameters.Add("@zero", SqlDbType.Int).Value = 0;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                InsertID(UserID);
                return true;

            }
            else
            {
                return false;
                //must checkout
            }

        }
        //add id if not found
        public bool FindID(int UserID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT * FROM Salary WHERE UserID =@UserID";
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                InsertID(UserID);
                return true;
            }
            else
            {
                return false;
            }
        }
        //
        public bool updateSalaryReception()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "UPDATE salary SET Checked=2, Salary =60000*(ABS(CAST(DATENAME(HOUR,CheckOut) AS int)-CAST(DATENAME(HOUR,CheckIn) AS int)) -ABS(ABS(CAST(DATENAME(HOUR,CheckOut) AS int)-CAST(DATENAME(HOUR,CheckIn) AS float))-8)) WHERE Checked=1 AND UserID IN (SELECT UserID FROM account WHERE Type ='Reception')";
            command.Parameters.Add("@one", SqlDbType.Int).Value = 1;
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
        public bool updateSalaryLabor()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "UPDATE salary SET Checked=2, Salary =40000*(ABS(CAST(DATENAME(HOUR,CheckOut) AS int)-CAST(DATENAME(HOUR,CheckIn) AS int)) -ABS(ABS(CAST(DATENAME(HOUR,CheckOut) AS int)-CAST(DATENAME(HOUR,CheckIn) AS float))-8)) WHERE Checked=1 AND UserID IN (SELECT UserID FROM account WHERE Type ='Labor')";
            command.Parameters.Add("@one", SqlDbType.Int).Value = 1;
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
        public DataTable showReport()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT salary.UserID as [ID],Type as [Position],Lname AS Name,SUM((ABS(CAST(DATENAME(HOUR,CheckOut) AS int)-CAST(DATENAME(HOUR,CheckIn) AS int)) -ABS(ABS(CAST(DATENAME(HOUR,CheckOut) AS int)-CAST(DATENAME(HOUR,CheckIn) AS float))-8))) AS [Time(work-quit)],SUM(salary) AS [Salary] FROM account INNER JOIN salary ON account.UserID=salary.UserID WHERE CAST( GETDATE() AS Date ) =CAST(CheckOut AS date) GROUP BY salary.UserID , Type,Lname ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable showReport(DateTime date)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT salary.UserID as [ID],Type as [Position],Lname AS Name,SUM((ABS(CAST(DATENAME(HOUR,CheckOut) AS int)-CAST(DATENAME(HOUR,CheckIn) AS int)) -ABS(ABS(CAST(DATENAME(HOUR,CheckOut) AS int)-CAST(DATENAME(HOUR,CheckIn) AS float))-8))) AS [Time(work-quit)],SUM(salary) AS [Salary] FROM account INNER JOIN salary ON account.UserID=salary.UserID WHERE CAST(@date AS Date ) =CAST(CheckOut AS date) GROUP BY salary.UserID , Type,Lname ";
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable StaticSalary()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_StaticSalary ", new object[] { });
            return data;
        }
        public DataTable StaticSalaryByDay(DateTime date1, DateTime date2)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_StaticSalaryByDay @date1 , @date2 ", new object[] { date1, date2 });
            return data;
        }
    }
}
