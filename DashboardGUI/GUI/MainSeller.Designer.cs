namespace DashboardGUI
{
    partial class MainSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSeller));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbStatus = new DashboardGUI.CustomComboBox();
            this.cbbStatus1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.cbbStatus);
            this.panel1.Controls.Add(this.cbbStatus1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 105);
            this.panel1.TabIndex = 8;
            // 
            // cbbStatus
            // 
            this.cbbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbStatus.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbStatus.BorderSize = 1;
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cbbStatus.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbbStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbStatus.Location = new System.Drawing.Point(543, 42);
            this.cbbStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Padding = new System.Windows.Forms.Padding(1);
            this.cbbStatus.Size = new System.Drawing.Size(200, 30);
            this.cbbStatus.TabIndex = 2;
            this.cbbStatus.Texts = "";
            this.cbbStatus.OnSelectedIndexChanged += new System.EventHandler(this.cbbStatus_SelectedValueChanged);
            // 
            // cbbStatus1
            // 
            this.cbbStatus1.FormattingEnabled = true;
            this.cbbStatus1.Location = new System.Drawing.Point(852, 44);
            this.cbbStatus1.Name = "cbbStatus1";
            this.cbbStatus1.Size = new System.Drawing.Size(167, 24);
            this.cbbStatus1.TabIndex = 1;
            this.cbbStatus1.SelectedIndexChanged += new System.EventHandler(this.cbbStatus_OnSelectedIndexChanged);
            this.cbbStatus1.SelectedValueChanged += new System.EventHandler(this.cbbStatus_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(749, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(172, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Employee";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Image = global::DashboardGUI.Properties.Resources.shutdown32;
            this.btnExit.Location = new System.Drawing.Point(33, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 15;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFloor2
            // 
            this.btnFloor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnFloor2.FlatAppearance.BorderSize = 0;
            this.btnFloor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloor2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFloor2.Image = ((System.Drawing.Image)(resources.GetObject("btnFloor2.Image")));
            this.btnFloor2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor2.Location = new System.Drawing.Point(1160, 24);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFloor2.Size = new System.Drawing.Size(120, 50);
            this.btnFloor2.TabIndex = 13;
            this.btnFloor2.Text = "Floor 2";
            this.btnFloor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFloor2.UseVisualStyleBackColor = false;
            this.btnFloor2.Click += new System.EventHandler(this.btnFloor2_Click);
            // 
            // btnFloor1
            // 
            this.btnFloor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnFloor1.FlatAppearance.BorderSize = 0;
            this.btnFloor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFloor1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloor1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFloor1.Image = ((System.Drawing.Image)(resources.GetObject("btnFloor1.Image")));
            this.btnFloor1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFloor1.Location = new System.Drawing.Point(1040, 24);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnFloor1.Size = new System.Drawing.Size(120, 50);
            this.btnFloor1.TabIndex = 11;
            this.btnFloor1.Text = "Floor 1";
            this.btnFloor1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFloor1.UseVisualStyleBackColor = false;
            this.btnFloor1.Click += new System.EventHandler(this.btnFloor1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pictureBox1.Image = global::DashboardGUI.Properties.Resources.Webp_net_resizeimage32;
            this.pictureBox1.Location = new System.Drawing.Point(134, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(37)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 648);
            this.panel2.TabIndex = 14;
            // 
            // MainSeller
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(42)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFloor2);
            this.Controls.Add(this.btnFloor1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainSeller";
            this.Load += new System.EventHandler(this.MainSeller_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbStatus1;
        private CustomComboBox cbbStatus;
    }
}