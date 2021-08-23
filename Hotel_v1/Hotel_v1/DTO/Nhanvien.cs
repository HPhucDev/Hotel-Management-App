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
    class Nhanvien
    {
        Data_Base mydb = new Data_Base();
        public bool insertNhanvien(string id, string fname, string lname, string address, string phone, MemoryStream picture, string password, string type)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Account(Username,Fname,Lname,Address,Phone,Picture,Password,Type) VALUES(@id,@fname,@lname,@address,@phone,@picture,@password,@type)";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
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
        public bool updateNhanvien(string id, string fname, string lname, string address, string phone, MemoryStream picture, string password, string type)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "UPDATE Account SET Fname =@fname, Lname=@lname, Address=@address,Phone=@phone,Password=@password,Type=@type,Picture=@picture WHERE Username=@id";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@type", SqlDbType.NVarChar).Value = type;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
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
        public bool checkUsername(string username)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Account WHERE Username =@key";
            command.Parameters.Add("@key", SqlDbType.NVarChar).Value = username;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public bool deleteNhanvien(string id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM Account WHERE Username=@id";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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
        public DataTable getAllNhanvien()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Account";
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable search(string key)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Account WHERE CONCAT(Username,Fname,Lname,Address,Phone,Type) LIKE '%" + key + "%'";
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable getManager()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Account WHERE Type=@key";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@key", SqlDbType.NVarChar).Value = "Manager";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getReception()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Account WHERE Type=@key";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@key", SqlDbType.NVarChar).Value = "Reception";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getLabor()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Account WHERE Type=@key";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@key", SqlDbType.NVarChar).Value = "Labor";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertCalendar(int id, string shift, DateTime date)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO calendar(ID,Shift,Date)" + "VALUES (@id,@shift,@date)";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("shift", SqlDbType.NVarChar).Value = shift;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
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
        public DataTable getCalendar()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ID, Fname AS [First Name],Lname AS [Last Name],Type AS [Position],Shift,CONVERT(varchar,Date,101) AS [Date],Phone FROM calendar INNER JOIN Account ON calendar.ID=Account.UserID";
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getTodayCalendar()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ID, Fname AS [First Name],Lname AS [Last Name],Type AS [Position],Shift,CONVERT(varchar,Date,101) AS [Date],Phone FROM calendar INNER JOIN Account ON calendar.ID=Account.UserID WHERE CONVERT(varchar,Date,101) =CONVERT(varchar,GETDATE(),101)";
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable get7dayCalendar()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ID, Fname AS [First Name],Lname AS [Last Name],Type AS [Position],Shift,CONVERT(varchar, Date,101) AS[Date],Phone FROM calendar INNER JOIN Account ON calendar.ID=Account.UserID WHERE CONVERT(varchar, Date,101) <CONVERT(varchar, DATEADD(d,7, GETDATE()),101) AND CONVERT(varchar, Date,101) >=CONVERT(varchar, GETDATE(),101)";
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getUser(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Account WHERE UserID=@id";
            command.Connection = mydb.getConnection;
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable findCalendar(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ID,Fname AS [First Name],Lname AS [Last Name],Type AS [Position],Shift,CONVERT(varchar,Date,101) AS [Date],Phone FROM calendar INNER JOIN Account ON calendar.ID=Account.UserID WHERE CONVERT(varchar,Date,101) >=CONVERT(varchar,GETDATE(),101) AND ID=@id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getMyCalendar(int userid)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Shift,CONVERT(varchar, Date,101) AS[Date] FROM calendar WHERE CONVERT(varchar,Date,101) >=CONVERT(varchar,GETDATE(),101) AND  ID=@userid";
            command.Parameters.Add("@userid", SqlDbType.Int).Value = userid;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
