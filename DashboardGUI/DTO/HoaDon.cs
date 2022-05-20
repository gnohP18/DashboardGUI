using System;
using System.Collections.Generic;

namespace DashboardGUI.DTO
{
    internal class HoaDon
    {
        public string ID_HoaDon { get; set; }
        public string ID_User { get; set; }
        public DateTime NgayLap { get; set; }
        public List<MonAn> DanhSachMonAn { get; set; }
    }
}
