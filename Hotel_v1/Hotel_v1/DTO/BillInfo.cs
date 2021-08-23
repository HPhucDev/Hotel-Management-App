using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_v1
{
    class BillInfo
    {
        public BillInfo(int id, int billID, int serviceID, int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.ServiceID = serviceID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.BillID = (int)row["idbill"];
            this.ServiceID = (int)row["idservice"];
            this.Count = (int)row["count"];
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int serviceID;

        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }

        private int billID;

        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
