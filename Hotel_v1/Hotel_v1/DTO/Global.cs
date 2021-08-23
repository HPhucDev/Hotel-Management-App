using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hotel_v1
{
    class Global
    {
        public static string globalUserType { get; private set; }
        public static void setGlobalUserType(string Type)
        {
            globalUserType = Type;
        }
        public static int globalUserID { get; private set; }
        public static void setGlobalUserID(int ID)
        {
            globalUserID = ID;
        }
        public static DataTable globalTableContactId { get; private set; }
        public static void setGlobalTableContactId(DataTable table)
        {
            globalTableContactId = table;
        }
    }
}
