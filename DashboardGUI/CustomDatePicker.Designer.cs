namespace DashboardGUI
{
    partial class CustomDatePicker
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
            this.customDateTimePicker1 = new DashboardGUI.CustomDateTimePicker();
            this.SuspendLayout();
            // 
            // customDateTimePicker1
            // 
            this.customDateTimePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customDateTimePicker1.BorderSize = 0;
            this.customDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.customDateTimePicker1.Location = new System.Drawing.Point(369, 120);
            this.customDateTimePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.customDateTimePicker1.Name = "customDateTimePicker1";
            this.customDateTimePicker1.Size = new System.Drawing.Size(207, 35);
            this.customDateTimePicker1.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.customDateTimePicker1.TabIndex = 0;
            this.customDateTimePicker1.TextColor = System.Drawing.Color.White;
            // 
            // CustomDatePicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customDateTimePicker1);
            this.Name = "CustomDatePicker";
            this.Text = "CustomDatePicker";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDateTimePicker customDateTimePicker1;
    }
}