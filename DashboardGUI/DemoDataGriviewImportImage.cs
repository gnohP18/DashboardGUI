using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DashboardGUI
{
    public partial class DemoDataGriviewImportImage : Form
    {
        public DemoDataGriviewImportImage()
        {
            InitializeComponent();
            CreateDemoEmployee();
            CreateAPictureForShift();
        }
        DataTable dt = new DataTable();
        void CreateDemoEmployee()
        {
            Bitmap imgTick = new Bitmap(@"E:\GUI\Icon For GUI\ImgRed.jpg");
            Bitmap imgUnTick = new Bitmap(@"E:\GUI\Icon For GUI\ImgGreen.png");
            //DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            dgvEmployee.Width = 1700;
            dgvEmployee.Height = 930;
            dt.Columns.Add("NameNV", typeof(string));
            dt.Columns.Add("T2S", typeof(Boolean));
            dt.Columns.Add("T2T", typeof(Boolean));
            dt.Columns.Add("T3S", typeof(Boolean));
            dt.Columns.Add("T3T", typeof(Boolean));
            dt.Rows.Add("NVA", true, false, true, true);
            dt.Rows.Add("NVB", true, true, true, true);
            dt.Rows.Add("NVC", true, false, true, true);
            dt.Rows.Add("NVD", true, true, true, true);
            dt.Rows.Add("NVE", true, true, false, true);
            dt.Rows.Add("NVF", false, false, true, true);
            dt.Rows.Add("NVG", true, true, true, false);
            dt.Rows.Add("NVH", true, true, true, true);
            dt.Rows.Add("NVI", false, true, false, true);
            dt.Rows.Add("NVJ", true, false, true, true);
            DataGridView dgv = new DataGridView();
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            DataGridViewImageColumn imageCol1 = new DataGridViewImageColumn();
            DataGridViewImageColumn imageCol2 = new DataGridViewImageColumn();
            DataGridViewImageColumn imageCol3 = new DataGridViewImageColumn();
            dgvEmployee.Columns.Add("Ten", "ten");
            dgvEmployee.Columns.Add(imageCol);
            dgvEmployee.Columns[1].HeaderText = "T2S";
            dgvEmployee.Columns.Add(imageCol1);
            dgvEmployee.Columns[2].HeaderText = "T2T";
            dgvEmployee.Columns.Add(imageCol2);
            dgvEmployee.Columns[3].HeaderText = "T3S";
            dgvEmployee.Columns.Add(imageCol3);
            dgvEmployee.Columns[4].HeaderText = "T3T";
            for (int i = 0; i < 10; i++)
            {
                dgvEmployee.Rows.Add();
                for (int j = 1; j < 5; j++)
                {
                    dgvEmployee.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    if (dt.Rows[i][j].Equals(true))
                    {
                        dgvEmployee.Rows[i].Cells[j].Value = imgTick;
                    }
                    else if (dt.Rows[i][j].Equals(false))
                    {
                        dgvEmployee.Rows[i].Cells[j].Value = imgUnTick;
                    }
                }
            }
            //dgvEmployee.DataSource = dt;
            this.Controls.Add(dgvEmployee);
        }
        void CreateAPictureForShift()
        {

            //dgvEmployee.DataSource = dt;
        }
    }
}
