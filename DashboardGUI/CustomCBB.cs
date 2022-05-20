using System.Windows.Forms;

namespace DashboardGUI
{
    public partial class CustomCBB : Form
    {
        public CustomCBB()
        {
            InitializeComponent();
        }
        void GUI()
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            lbltextsearch.Text = txtDemo.Text;
        }
    }
}
