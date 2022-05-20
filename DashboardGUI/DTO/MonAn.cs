using System.Drawing;

namespace DashboardGUI.DTO
{
    internal class MonAn
    {
        public string ID_MonAn { get; set; }
        public string TenMonAn { get; set; }

        public int ThanhTien { get; set; }

        public Bitmap AnhMonAn { get; set; }
        public override string ToString()
        {
            return TenMonAn;
        }
    }
}
