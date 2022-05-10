using DashboardGUI.BLL;
using System;
using System.Windows.Forms;

namespace DashboardGUI
{
    public partial class MainSeller : Form
    {
        public MainSeller()
        {
            InitializeComponent();
            SetCbb();

        }
        void SetCbb()
        {
            cbbStatus.Items.Add("All");
            cbbStatus.Items.Add("Emty");
            cbbStatus.Items.Add("Busy");
        }
        int Floor = 0;
        void SetTable(Panel pn, TableView tb, int id, int fl, bool st)
        {
            tb.Width = 300;
            tb.Height = 200;
            pn.Controls.Add(tb);
            tb.IDTable = id;
            tb.Floor = fl;
            tb.statusTable = st;
            tb.GUITable();
            //tb.Visible = true;
        }

        void LoadTable()
        {

            TableView[] tb = new TableView[QLTableBLL.Instance.NumberOfStatus(statustb)];
            int dem1 = 0;
            foreach (string i in QLTableBLL.Instance.GetListTableStatus2(statustb))
            {
                tb[dem1] = new TableView();
                tb[dem1].IDTable = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).IDTable;
                tb[dem1].Floor = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).Floor;
                tb[dem1].statusTable = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).Status;
                dem1++;
            }
            int soluongban = QLTableBLL.Instance.NumberOfStatus(statustb);
            for (int i = 0; i < soluongban; i++)
            {

            }
            if (soluongban != 0)
            {
                for (int i = 0; i < tb.Length; i++)
                {
                    int Lx = 0, Ly = 0;
                    if (i % 3 == 0) Lx = 20;
                    else if (i % 3 == 1)
                    {
                        Lx = 420;
                    }
                    else if (i % 3 == 2)
                    {
                        Lx = 820;
                    }
                    int thuong = Convert.ToInt32(i / 3);
                    Ly = 25 + 260 * thuong;
                    tb[i].SetLocation(Lx, Ly);
                    Console.WriteLine(tb[i].IDTable + " " + Ly + " " + Lx);
                    SetTable(panel2, tb[i], tb[i].IDTable, Floor, tb[i].statusTable);
                }
            }
        }
        private void btnFloor1_Click(object sender, EventArgs e)
        {
            Floor = 1;
            //LoadTable();
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            Floor = 2;
            //LoadTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainSeller_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        bool statustb;
        private void cbbStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStatus1.SelectedIndex == 1)
            {
                statustb = true;
                RemoveTable();
                LoadTable();
            }
            else if (cbbStatus1.SelectedIndex == 2)
            {
                statustb = false;
                RemoveTable();
                LoadTable();
            }
            else if (cbbStatus1.SelectedIndex == 0) { }
        }
        void RemoveTable()
        {
            panel2.Controls.Clear();
        }
        private void cbbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cbbStatus.SelectedIndex == 1)
            //{
            //    statustb = false;
            //    RemoveTable();
            //    LoadTable();
            //}
            //else if (cbbStatus.SelectedIndex == 2)
            //{
            //    statustb = true;
            //    RemoveTable();
            //    LoadTable();
            //}
        }
    }
}
