namespace DashboardGUI.GUI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDrinking = new System.Windows.Forms.Button();
            this.btnHotPod = new System.Windows.Forms.Button();
            this.btnAppetizer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOrderMenu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDrinking);
            this.panel1.Controls.Add(this.btnHotPod);
            this.panel1.Controls.Add(this.btnAppetizer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Image = global::DashboardGUI.Properties.Resources.shutdown32;
            this.btnExit.Location = new System.Drawing.Point(1246, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDrinking
            // 
            this.btnDrinking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnDrinking.FlatAppearance.BorderSize = 0;
            this.btnDrinking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinking.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDrinking.Image = global::DashboardGUI.Properties.Resources.water;
            this.btnDrinking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrinking.Location = new System.Drawing.Point(274, 12);
            this.btnDrinking.Name = "btnDrinking";
            this.btnDrinking.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDrinking.Size = new System.Drawing.Size(130, 50);
            this.btnDrinking.TabIndex = 14;
            this.btnDrinking.Text = "Drinking";
            this.btnDrinking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrinking.UseVisualStyleBackColor = false;
            // 
            // btnHotPod
            // 
            this.btnHotPod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnHotPod.FlatAppearance.BorderSize = 0;
            this.btnHotPod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotPod.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotPod.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHotPod.Image = global::DashboardGUI.Properties.Resources.dish;
            this.btnHotPod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotPod.Location = new System.Drawing.Point(138, 12);
            this.btnHotPod.Name = "btnHotPod";
            this.btnHotPod.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnHotPod.Size = new System.Drawing.Size(130, 50);
            this.btnHotPod.TabIndex = 13;
            this.btnHotPod.Text = "Hot Pod";
            this.btnHotPod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHotPod.UseVisualStyleBackColor = false;
            // 
            // btnAppetizer
            // 
            this.btnAppetizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnAppetizer.FlatAppearance.BorderSize = 0;
            this.btnAppetizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppetizer.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppetizer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAppetizer.Image = global::DashboardGUI.Properties.Resources.salad;
            this.btnAppetizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppetizer.Location = new System.Drawing.Point(12, 12);
            this.btnAppetizer.Name = "btnAppetizer";
            this.btnAppetizer.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAppetizer.Size = new System.Drawing.Size(120, 50);
            this.btnAppetizer.TabIndex = 12;
            this.btnAppetizer.Text = "Salad";
            this.btnAppetizer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppetizer.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 620);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.dgvOrderMenu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(800, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 620);
            this.panel3.TabIndex = 2;
            // 
            // dgvOrderMenu
            // 
            this.dgvOrderMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.dgvOrderMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrderMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.dgvOrderMenu.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderMenu.MultiSelect = false;
            this.dgvOrderMenu.Name = "dgvOrderMenu";
            this.dgvOrderMenu.RowHeadersWidth = 51;
            this.dgvOrderMenu.RowTemplate.Height = 24;
            this.dgvOrderMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderMenu.Size = new System.Drawing.Size(500, 360);
            this.dgvOrderMenu.TabIndex = 0;
            this.dgvOrderMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderMenu_CellClick);
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAppetizer;
        private System.Windows.Forms.Button btnHotPod;
        private System.Windows.Forms.Button btnDrinking;
        private System.Windows.Forms.DataGridView dgvOrderMenu;
        private System.Windows.Forms.Button btnExit;
    }
}