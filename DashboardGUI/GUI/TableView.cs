using DashboardGUI.GUI;
using System.Drawing;
using System.Windows.Forms;

namespace DashboardGUI
{
    public partial class TableView : UserControl
    {
        public int IDTable { get; set; }
        public int Floor { get; set; }
        public bool statusTable { get; set; }

        public TableView()
        {
            InitializeComponent();
        }
        Bitmap pGreen = Properties.Resources.checkedGreen;
        Bitmap pRed = Properties.Resources.uncheckedRed;
        public void GUITable()
        {
            lblFloorNumber.Text = Floor.ToString();
            lblIDTable.Text = IDTable.ToString();
            if (statusTable)
            {
                pBStatusTable.Image = Properties.Resources.checkedGreen;
            }
            else if (statusTable == false)
            {
                pBStatusTable.Image = Properties.Resources.uncheckedRed;
            }
        }
        public void SetLocation(int x, int y)
        {
            Location = new Point(x, y);
        }

        private void btnMenuOrder_Click(object sender, System.EventArgs e)
        {
            OrderForm frm = new OrderForm();
            frm.Show();
        }

        private void btnPay_Click(object sender, System.EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
