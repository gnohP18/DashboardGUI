using DashboardGUI.DAL;
using DashboardGUI.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DashboardGUI.BLL
{
    internal class QLMonAnBLL
    {
        private static QLMonAnBLL _Instance;

        internal static QLMonAnBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLMonAnBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public QLMonAnBLL()
        {

        }
        public List<MonAn> GetAllDish()
        {
            List<MonAn> Data = new List<MonAn>();
            foreach (DataRow i in DataMonAnTest.Instance.DataMon.Rows)
            {
                Data.Add(GetDataMonAnbyRow(i));
            }
            return Data;
        }

        public MonAn GetDataMonAnbyRow(DataRow i)
        {
            return new MonAn
            {
                ID_MonAn = i[0].ToString(),
                TenMonAn = i[1].ToString(),
                ThanhTien = Convert.ToInt32(i[2].ToString())
            };
        }
        public MonAn GetDataDishbyID(string id)
        {
            MonAn dish = null;
            foreach (DataRow i in DataMonAnTest.Instance.DataMon.Rows)
            {
                if (i[0].ToString() == id)
                {
                    dish.ID_MonAn = i[0].ToString();
                    dish.TenMonAn = i[1].ToString();
                    dish.ThanhTien = Convert.ToInt32(i[2].ToString());
                }
            }
            return dish;
        }
    }
}
