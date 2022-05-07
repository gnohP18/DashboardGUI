namespace DashboardGUI
{
    partial class MenuStripTest
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.customDropDownMenu1 = new DashboardGUI.CustomDropDownMenu(this.components);
            this.heheheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hahahaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDropDownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customDropDownMenu1
            // 
            this.customDropDownMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customDropDownMenu1.IsMainMenu = false;
            this.customDropDownMenu1.ItemMenuHieght = 25;
            this.customDropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heheheToolStripMenuItem});
            this.customDropDownMenu1.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.customDropDownMenu1.Name = "customDropDownMenu1";
            this.customDropDownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.customDropDownMenu1.Size = new System.Drawing.Size(127, 28);
            // 
            // heheheToolStripMenuItem
            // 
            this.heheheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hahahaToolStripMenuItem});
            this.heheheToolStripMenuItem.Name = "heheheToolStripMenuItem";
            this.heheheToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.heheheToolStripMenuItem.Text = "hehehe";
            // 
            // hahahaToolStripMenuItem
            // 
            this.hahahaToolStripMenuItem.Name = "hahahaToolStripMenuItem";
            this.hahahaToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.hahahaToolStripMenuItem.Text = "hahaha";
            // 
            // MenuStripTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "MenuStripTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuStripTest";
            this.Load += new System.EventHandler(this.MenuStripTest_Load);
            this.customDropDownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDropDownMenu customDropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem heheheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hahahaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}