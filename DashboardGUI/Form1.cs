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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(26, 30, 62);
            btnOK.AutoSize=true;
        }
        private Button CurrentButton;
        private void SetUIForButton(object button)
        {
            //Tạo 1 btn ép về kiểu Button
            var btn = (Button)button;
            //Highlight button
            //btn.BackColor = btntest1.FlatAppearance.BorderColor;
            btn.BackColor = Color.FromArgb(78, 76, 150);//tạo màu nền cho btn
            btn.ForeColor = Color.White;//tạo màu chữ cho btn
            //Unhighlight button
            if (CurrentButton != null && CurrentButton != btn)//Kiếm tra xem btn có đc chọn hay k
            {

                CurrentButton.BackColor = this.BackColor;
                CurrentButton.ForeColor = Color.White;
            }

            //Set current button
            CurrentButton = btn;
            //Sử dụng bằng cách 
            //private void button2_Click(object sender, EventArgs e)
            //{
            //    SetUIForButton(sender);
            //}

        }
        private void btntest1_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }
        private void btnTest2_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }
        private void btnTest3_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }

        private void btnTest4_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }

        private void btnTest5_Click(object sender, EventArgs e)
        {
            SetUIForButton(sender);
        }
    }
}



