using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_v1
{
    class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }

        public static int RoomWidth = 100;
        public static int RoomHeight = 100;

        private RoomDAO() { }
        public void InsertRoom(string name ,string status)
        {
            DataProvider.Instance.ExecuteQuery("USP_InsertRoom @name , @status", new object[] { name, status });
        }
        public void UpdateRoom(int id, string status)
        {
            DataProvider.Instance.ExecuteQuery("USP_UpdateRoom @name , @status", new object[] { id, status });
        }
        public void DeleteRoom(string name)
        {
            DataProvider.Instance.ExecuteQuery("USP_DeleteRoom @name", new object[] { name });
        }
        public void SwitchRoom(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchRoom @idRoom1 , @idRoom2", new object[] { id1, id2 });
        }
        public DataTable GetAllRoom()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList");
            return data;
        }
        public DataTable CheckRoom(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomDetail @id", new object[] { id });
            return data;
        }
        public List<Room> LoadRoomList()
        {
            List<Room> RoomList = new List<Room>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetRoomList");

            foreach (DataRow item in data.Rows)
            {
                Room Room = new Room(item);
                RoomList.Add(Room);
            }

            return RoomList;
        }
    }
}
