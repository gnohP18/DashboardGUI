﻿namespace DashboardGUI
{
    partial class TableView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIDTable = new System.Windows.Forms.Label();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pBStatusTable = new System.Windows.Forms.PictureBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnMenuOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatusTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.lblIDTable);
            this.panel1.Location = new System.Drawing.Point(7, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 148);
            this.panel1.TabIndex = 10;
            // 
            // lblIDTable
            // 
            this.lblIDTable.AutoSize = true;
            this.lblIDTable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTable.ForeColor = System.Drawing.Color.Black;
            this.lblIDTable.Location = new System.Drawing.Point(78, 56);
            this.lblIDTable.Name = "lblIDTable";
            this.lblIDTable.Size = new System.Drawing.Size(37, 34);
            this.lblIDTable.TabIndex = 6;
            this.lblIDTable.Text = "B";
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.AutoSize = true;
            this.lblFloorNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorNumber.ForeColor = System.Drawing.Color.Black;
            this.lblFloorNumber.Location = new System.Drawing.Point(70, 8);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Size = new System.Drawing.Size(24, 23);
            this.lblFloorNumber.TabIndex = 9;
            this.lblFloorNumber.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Floor";
            // 
            // pBStatusTable
            // 
            this.pBStatusTable.Location = new System.Drawing.Point(204, 45);
            this.pBStatusTable.Name = "pBStatusTable";
            this.pBStatusTable.Size = new System.Drawing.Size(32, 32);
            this.pBStatusTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBStatusTable.TabIndex = 11;
            this.pBStatusTable.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Image = global::DashboardGUI.Properties.Resources.calculator;
            this.btnPay.Location = new System.Drawing.Point(199, 149);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(40, 40);
            this.btnPay.TabIndex = 7;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnMenuOrder
            // 
            this.btnMenuOrder.FlatAppearance.BorderSize = 0;
            this.btnMenuOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOrder.Image = global::DashboardGUI.Properties.Resources.restaurant32;
            this.btnMenuOrder.Location = new System.Drawing.Point(198, 94);
            this.btnMenuOrder.Name = "btnMenuOrder";
            this.btnMenuOrder.Size = new System.Drawing.Size(40, 40);
            this.btnMenuOrder.TabIndex = 6;
            this.btnMenuOrder.UseVisualStyleBackColor = true;
            this.btnMenuOrder.Click += new System.EventHandler(this.btnMenuOrder_Click);
            // 
            // TableView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFloorNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBStatusTable);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnMenuOrder);
            this.Name = "TableView";
            this.Size = new System.Drawing.Size(250, 200);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBStatusTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIDTable;
        private System.Windows.Forms.Label lblFloorNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBStatusTable;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnMenuOrder;
    }
}
