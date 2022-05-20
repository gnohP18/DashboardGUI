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
            tb.Width = 250;
            tb.Height = 200;
            pn.Controls.Add(tb);
            tb.IDTable = id;
            tb.Floor = fl;
            tb.statusTable = st;
            tb.GUITable();
            //tb.Visible = true;
        }
        void LoadTableWithStatusAndFloor(bool st, int fl)
        {
            TableView[] tb = new TableView[QLTableBLL.Instance.NumberOfStatusAndFloor(statustb, fl)];
            int dem1 = 0;
            foreach (string i in QLTableBLL.Instance.GetListTableStatusAndFloor(statustb, fl))
            {
                tb[dem1] = new TableView();
                tb[dem1].IDTable = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).IDTable;
                tb[dem1].Floor = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).Floor;
                tb[dem1].statusTable = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).Status;
                dem1++;
            }
            int soluongban = QLTableBLL.Instance.NumberOfStatusAndFloor(statustb, fl);
            for (int i = 0; i < soluongban; i++)
            {

            }
            if (soluongban != 0)
            {
                for (int i = 0; i < tb.Length; i++)
                {
                    int Lx = 0, Ly = 0;
                    if (i % 4 == 0) Lx = 20;
                    else if (i % 4 == 1)
                    {
                        Lx = 330;
                    }
                    else if (i % 4 == 2)
                    {
                        Lx = 630;
                    }
                    else if (i % 4 == 3)
                    {
                        Lx = 930;
                    }
                    int thuong = Convert.ToInt32(i / 4);
                    Ly = 25 + 260 * thuong;
                    tb[i].SetLocation(Lx, Ly);
                    //Console.WriteLine(tb[i].IDTable + " " + Ly + " " + Lx);
                    SetTable(panel2, tb[i], tb[i].IDTable, Floor, tb[i].statusTable);
                }
            }
        }
        void LoadAllTableWithFloor(int fl)
        {
            int soban = QLTableBLL.Instance.NumberOfStatusAndFloor(true, fl) + QLTableBLL.Instance.NumberOfStatusAndFloor(false, fl);
            TableView[] tb = new TableView[soban];
            int dem1 = 0;
            foreach (string i in QLTableBLL.Instance.GetAllTableWithFloor(fl))
            {
                tb[dem1] = new TableView();
                tb[dem1].IDTable = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).IDTable;
                tb[dem1].Floor = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).Floor;
                tb[dem1].statusTable = QLTableBLL.Instance.GetSVByIDTbale(Convert.ToInt32(i.ToString())).Status;
                dem1++;
            }
            int soluongban = soban;
            if (soluongban != 0)
            {
                for (int i = 0; i < tb.Length; i++)
                {
                    int Lx = 0, Ly = 0;
                    if (i % 4 == 0) Lx = 20;
                    else if (i % 4 == 1)
                    {
                        Lx = 330;
                    }
                    else if (i % 4 == 2)
                    {
                        Lx = 630;
                    }
                    else if (i % 4 == 3)
                    {
                        Lx = 930;
                    }
                    int thuong = Convert.ToInt32(i / 4);
                    Ly = 25 + 260 * thuong;
                    tb[i].SetLocation(Lx, Ly);
                    //Console.WriteLine(tb[i].IDTable + " " + Ly + " " + Lx);
                    SetTable(panel2, tb[i], tb[i].IDTable, Floor, tb[i].statusTable);
                }
            }
        }
        private void btnFloor1_Click(object sender, EventArgs e)
        {
            Floor = 1;
            RemoveTable();
            LoadTableWithStatusAndFloor(statustb, Floor);
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            Floor = 2;
            RemoveTable();
            LoadTableWithStatusAndFloor(statustb, Floor);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainSeller_Load(object sender, EventArgs e)
        {
            LoadTableWithStatusAndFloor(statustb, Floor);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        bool statustb;
        private void cbbStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbStatus.SelectedIndex == 1)
            {
                statustb = true;
                RemoveTable();
                LoadTableWithStatusAndFloor(statustb, Floor);
            }
            else if (cbbStatus.SelectedIndex == 2)
            {
                statustb = false;
                RemoveTable();
                LoadTableWithStatusAndFloor(statustb, Floor);
            }
            else if (cbbStatus.SelectedIndex == 0)
            {
                RemoveTable();
                LoadAllTableWithFloor(Floor);
            }
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
