using System;
using System.Windows.Forms;

namespace DashboardGUI
{
    public partial class MainSeller : Form
    {
        public MainSeller()
        {
            InitializeComponent();
            LoadTable();
        }
        int Floor = 0;
        void SetTable(Table tb, int id, int fl, bool st)
        {
            tb.IDTable = id;
            tb.Floor = fl;
            tb.statusTable = st;
            tb.GUITable();
        }
        void LoadTable()
        {
            SetTable(table1, 1, Floor, true);
            SetTable(table2, 2, Floor, false);
            SetTable(table3, 3, Floor, true);
            SetTable(table4, 4, Floor, false);
            SetTable(table5, 5, Floor, false);
            SetTable(table6, 6, Floor, true);
            SetTable(table7, 7, Floor, true);
            SetTable(table8, 8, Floor, true);
            SetTable(table9, 9, Floor, true);
        }
        private void btnFloor1_Click(object sender, EventArgs e)
        {
            Floor = 1;
            LoadTable();
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            Floor = 2;
            LoadTable();
        }
    }
}
