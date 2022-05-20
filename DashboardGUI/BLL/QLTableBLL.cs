using DashboardGUI.DAL;
using DashboardGUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DashboardGUI.BLL
{
    internal class QLTableBLL
    {
        private static QLTableBLL _Instance;

        internal static QLTableBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLTableBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public QLTableBLL()
        {

        }
        public List<TableTest> GetAllTable()
        {
            List<TableTest> Data = new List<TableTest>();
            foreach (DataRow i in DataTableTest.Instance.Datatb.Rows)
            {
                Data.Add(GetDataTablebyRow(i));
            }
            return Data;
        }

        public TableTest GetDataTablebyRow(DataRow i)
        {
            return new TableTest
            {
                IDTable = Convert.ToInt32(i[0].ToString()),
                Floor = Convert.ToInt32(i[1].ToString()),
                Status = Convert.ToBoolean(i[2].ToString()),
            };
        }

        public int NumberOfStatusAndFloor(bool st, int fl)
        {
            int dem = 0;
            foreach (TableTest i in GetAllTable())
            {
                if (i.Status.Equals(st) && i.Floor.Equals(fl))
                    dem++;
            }
            return dem;
        }
        public TableTest GetSVByIDTbale(int id)
        {
            TableTest table = null;
            foreach (TableTest i in QLTableBLL.Instance.GetAllTable())
            {
                if (i.IDTable == id)
                {
                    table = i;
                    break;
                }
            }
            return table;
        }
        public List<TableTest> GetListTableStatus(bool st)
        {
            List<TableTest> data = new List<TableTest>();
            foreach (TableTest i in GetAllTable())
            {
                if (i.Status.Equals(st))
                    data.Add(i);
            }
            return data;
        }
        public List<string> GetListTableStatusAndFloor(bool st, int fl)
        {
            List<string> data = new List<string>();
            foreach (TableTest i in GetAllTable())
            {
                if (i.Status.Equals(st) && i.Floor.Equals(fl))
                    data.Add(i.IDTable.ToString());
            }
            return data;
        }
        public List<string> GetAllTableWithFloor(int fl)
        {
            List<string> data = new List<string>();
            foreach (TableTest i in GetAllTable())
            {
                if (i.Floor.Equals(fl))
                    data.Add(i.IDTable.ToString());
            }
            return data;
        }
    }
}

