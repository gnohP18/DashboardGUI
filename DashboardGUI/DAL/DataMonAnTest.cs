using System.Data;

namespace DashboardGUI.DAL
{
    internal class DataMonAnTest
    {
        private static DataMonAnTest _Instance;
        internal static DataMonAnTest Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DataMonAnTest();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable DataMon;
        public DataMonAnTest()
        {
            DataMon = new DataTable();
            DataMon.Columns.Add("ID_MonAn", typeof(string));
            DataMon.Columns.Add("TenMonAn", typeof(string));
            DataMon.Columns.Add("ThanhTien", typeof(int));
            DataMon.Rows.Add("MA101", "Ga Xoi Mo", 100);
            DataMon.Rows.Add("MA102", "Ca Loc nuong", 100);
            DataMon.Rows.Add("MA103", "Ga Nuong", 100);
            DataMon.Rows.Add("MA104", "Goi cuon", 100);
            DataMon.Rows.Add("MA105", "Lau thai", 100);
            DataMon.Rows.Add("MA106", "Lau hai san", 100);
            DataMon.Rows.Add("MA107", "Chim se ro ti", 100);
            DataMon.Rows.Add("MA108", "Xao nai", 100);
            DataMon.Rows.Add("MA109", "Rau muong xao toi", 100);
            DataMon.Rows.Add("MA110", "Com chien trung", 100);
            DataMon.Rows.Add("MA111", "Ca ra banh mi", 100);
            DataMon.Rows.Add("MA112", "Cut lon xao me", 100);
            DataMon.Rows.Add("MA113", "Larue", 100);
            DataMon.Rows.Add("MA114", "Huda", 100);
            DataMon.Rows.Add("MA115", "Fanta cam", 100);
            DataMon.Rows.Add("MA116", "Fanta viet quat", 100);
            DataMon.Rows.Add("MA117", "Aquafina", 100);
        }
    }
}
