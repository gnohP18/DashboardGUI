using System;
using System.Collections.Generic;

namespace DashboardGUI.BLL
{
    internal class QLDanhSachMonAnBLL
    {
        private static QLDanhSachMonAnBLL _Instance;

        internal static QLDanhSachMonAnBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLDanhSachMonAnBLL();
                }
                return _Instance;
            }
            private set { }
        }

        public QLDanhSachMonAnBLL()
        {

        }
        public List<QLMonAnBLL> DanhSachMonAn(List<String> idmonan)
        {
            List<QLMonAnBLL> danhsach = new List<QLMonAnBLL>();
            for (int i = 0; i < idmonan.Count; i++)
            {
                //danhsach.Add(QLMonAnBLL.Instance.GetDataDishbyID(idmonan[i].ToString());
            }
            return danhsach;
        }
    }
}
