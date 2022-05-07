using System.Drawing;
using System.Windows.Forms;

namespace DashboardGUI
{
    public partial class Table : UserControl
    {
        public int IDTable { get; set; }
        public int Floor { get; set; }
        public bool statusTable { get; set; }

        public Table()
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
    }
}
