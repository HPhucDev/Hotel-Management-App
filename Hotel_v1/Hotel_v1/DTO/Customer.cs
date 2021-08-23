using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_v1
{
    class Customer
    {
        public Customer(int id,int idroom, int idbill, string fname, string lname,string cmnd,string sex,string phone,string address,DateTime datecheckin,DateTime datecheckout)
        {
            this.ID = id;
            this.IDRoom = idroom;
            this.IDBill = idbill;
            this.Fname = fname;
            this.Lname = lname;
            this.Sex = sex;
            this.Phone = phone;
            this.Address = address;
            this.DateCheckIn = datecheckin;
            this.DateCheckOut = datecheckout;
        }

        public Customer(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDRoom = (int)row["IDRoom"];
            this.IDBill = (int)row["IDBill"];
            this.Fname = (string)row["Fname"];
            this.Lname = (string)row["Lname"];
            this.Sex = (string)row["Sex"];
            this.Phone = (string)row["Phone"];
            this.Address = (string)row["Address"];
            this.DateCheckIn = (DateTime)row["DateCheckIn"];
            this.DateCheckOut = (DateTime)row["DateCheckOut"];
        }

        private int id;
        public int ID
        {
            get { return id; }
            set { id= value; }
        }
        private int idroom;
        public int IDRoom
        {
            get { return idroom; }
            set { idroom = value; }
        }
        private int idbill;
        public int IDBill
        {
            get { return idbill; }
            set { idbill = value; }
        }
        private string fname;
        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        private string lname;
        public string Lname
        {
            get { return lname; }
            set {lname = value; }
        }
        private string sex;
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone= value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private DateTime datecheckin;
        public DateTime DateCheckIn
        {
            get { return datecheckin; }
            set { datecheckin = value; }
        }
        private DateTime datecheckout;
        public DateTime DateCheckOut
        {
            get { return datecheckout; }
            set { datecheckout= value; }
        }
    }
}
