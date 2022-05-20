using System.Data;

namespace DashboardGUI.DAL
{
    internal class DataTableTest
    {
        private static DataTableTest _Instance;
        internal static DataTableTest Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DataTableTest();
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable Datatb;
        public DataTableTest()
        {
            Datatb = new DataTable();
            Datatb.Columns.Add("ID", typeof(int));
            Datatb.Columns.Add("Floor", typeof(int));
            Datatb.Columns.Add("Status", typeof(bool));
            Datatb.Rows.Add(1001, 1, true);
            Datatb.Rows.Add(1002, 1, false);
            Datatb.Rows.Add(1003, 1, false);
            Datatb.Rows.Add(1004, 1, true);
            Datatb.Rows.Add(1005, 1, true);
            Datatb.Rows.Add(1006, 1, false);
            Datatb.Rows.Add(1007, 1, false);
            Datatb.Rows.Add(1008, 1, true);
            Datatb.Rows.Add(1009, 1, false);
            Datatb.Rows.Add(1010, 1, true);
            Datatb.Rows.Add(1011, 1, false);
            Datatb.Rows.Add(1012, 1, true);
            Datatb.Rows.Add(1013, 1, false);
            Datatb.Rows.Add(1014, 1, true);
            Datatb.Rows.Add(1015, 1, false);
            Datatb.Rows.Add(1016, 1, true);
            Datatb.Rows.Add(1017, 1, false);
            Datatb.Rows.Add(1018, 1, false);
            Datatb.Rows.Add(1019, 1, true);
            Datatb.Rows.Add(1020, 1, true);
            Datatb.Rows.Add(1021, 1, false);
            Datatb.Rows.Add(1022, 1, false);
            Datatb.Rows.Add(1023, 1, true);
            Datatb.Rows.Add(1024, 1, false);
            Datatb.Rows.Add(1025, 1, true);
            Datatb.Rows.Add(1026, 1, false);
            Datatb.Rows.Add(1027, 1, true);
            Datatb.Rows.Add(1028, 1, false);
            Datatb.Rows.Add(1029, 1, true);
            Datatb.Rows.Add(1030, 1, false);
            Datatb.Rows.Add(2001, 2, false);
            Datatb.Rows.Add(2002, 2, true);
            Datatb.Rows.Add(2003, 2, true);
            Datatb.Rows.Add(2004, 2, false);
            Datatb.Rows.Add(2005, 2, false);
            Datatb.Rows.Add(2006, 2, true);
            Datatb.Rows.Add(2007, 2, true);
            Datatb.Rows.Add(2008, 2, false);
            Datatb.Rows.Add(2009, 2, true);
            Datatb.Rows.Add(2010, 2, false);
            Datatb.Rows.Add(2011, 2, true);
            Datatb.Rows.Add(2012, 2, false);
            Datatb.Rows.Add(2013, 2, true);
            Datatb.Rows.Add(2014, 2, true);
            Datatb.Rows.Add(2015, 2, true);
            Datatb.Rows.Add(2016, 2, true);
            Datatb.Rows.Add(2017, 2, false);
            Datatb.Rows.Add(2018, 2, false);
            Datatb.Rows.Add(2019, 2, true);
            Datatb.Rows.Add(2020, 2, true);
            Datatb.Rows.Add(2021, 2, false);
            Datatb.Rows.Add(2022, 2, false);
            Datatb.Rows.Add(2023, 2, true);
            Datatb.Rows.Add(2024, 2, false);
            Datatb.Rows.Add(2025, 2, true);
            Datatb.Rows.Add(2026, 2, false);
            Datatb.Rows.Add(2027, 2, true);
            Datatb.Rows.Add(2028, 2, false);
            Datatb.Rows.Add(2029, 2, true);
            Datatb.Rows.Add(2030, 2, false);
        }
    }
}
