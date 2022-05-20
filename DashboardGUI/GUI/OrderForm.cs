using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DashboardGUI.GUI
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            SetDataGridView();

        }
        //Du lieu loccal
        DataTable dt = new DataTable();
        void SetDataDish()
        {
            dt.Columns.Add("MaMonAn", typeof(string));
            dt.Columns.Add("TenMonAn", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("ThanhTien", typeof(int));
            dt.Rows.Add("101", "Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 1, 1000);
            dt.Rows.Add("102", "B", 2, 1000);
            dt.Rows.Add("103", "C", 1, 1000);
            dt.Rows.Add("104", "D", 3, 1000);
            dt.Rows.Add("105", "E", 5, 1000);
            dt.Rows.Add("106", "F", 7, 1000);
            dt.Rows.Add("107", "G", 1, 1000);
        }
        void AddData()
        {

        }
        //Set GUI datagridview
        void SetDataGridView()
        {
            SetDataDish();
            dgvOrderMenu.DataSource = dt;
            dgvOrderMenu.ReadOnly = true;
            dgvOrderMenu.ForeColor = Color.FromArgb(17, 21, 37);
            dgvOrderMenu.MultiSelect = false;
            dgvOrderMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvOrderMenu.Columns[0].HeaderText = "Mã món ăn";
            dgvOrderMenu.Columns[0].Width = 50;
            dgvOrderMenu.Columns[1].HeaderText = "Tên món ăn";
            dgvOrderMenu.Columns[1].Width = 130;
            dgvOrderMenu.Columns[2].HeaderText = "Số lượng";
            dgvOrderMenu.Columns[2].Width = 50;
            dgvOrderMenu.Columns[3].HeaderText = "Thành tiền";
            dgvOrderMenu.Columns[3].Width = 130;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Del";
            button.HeaderText = "Del";
            button.Name = "btnDelDish";
            button.UseColumnTextForButtonValue = true;
            button.FlatStyle = FlatStyle.Flat;
            dgvOrderMenu.Columns.Add(button);
            dgvOrderMenu.Columns[4].Width = 90;
            AddData();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void dgvOrderMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Button btn = (Button)sender;
                MessageBox.Show("Xoa");
            }
        }
    }

}
