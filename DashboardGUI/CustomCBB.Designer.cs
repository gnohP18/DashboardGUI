namespace DashboardGUI
{
    partial class CustomCBB
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customComboBox1 = new DashboardGUI.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DashboardGUI.Properties.Resources.DarkCalendar;
            this.pictureBox2.Location = new System.Drawing.Point(524, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DashboardGUI.Properties.Resources.LightCalendar;
            this.pictureBox1.Location = new System.Drawing.Point(459, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // customComboBox1
            // 
            this.customComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customComboBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.BorderSize = 2;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.customComboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "AA",
            "BB",
            "CC",
            "a",
            "b",
            "c",
            "d",
            "e",
            "aaa",
            "bbb",
            "ccc"});
            this.customComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.customComboBox1.Location = new System.Drawing.Point(124, 78);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBox1.Size = new System.Drawing.Size(294, 51);
            this.customComboBox1.TabIndex = 0;
            this.customComboBox1.Texts = "";
            // 
            // CustomCBB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customComboBox1);
            this.Name = "CustomCBB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomComboBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomComboBox customComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}