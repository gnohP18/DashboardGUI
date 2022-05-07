using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardGUI
{
    public partial class MenuStripTest : Form
    {
        public MenuStripTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customDropDownMenu1.Show(button1.Location.X,button1.Location.Y);
        }

        private void MenuStripTest_Load(object sender, EventArgs e)
        {
            customDropDownMenu1.IsMainMenu = true;
        }
    }
}
