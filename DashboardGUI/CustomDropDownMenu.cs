using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace DashboardGUI
{
    public class CustomDropDownMenu : ContextMenuStrip
    {
        //Fields
        private bool isMainMenu;
        private int itemMenuHieght = 25;
        private Color menuItemTextColor = Color.DimGray;
        private Color primaryColor = Color.MediumSlateBlue;

        private Bitmap menuItemHeaderSize;

        //Constructor
        public CustomDropDownMenu(IContainer container) : base(container)
        {

        }

        //properties
        [Browsable(false)]
        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }
        [Browsable(false)]
        public int ItemMenuHieght { get => itemMenuHieght; set => itemMenuHieght = value; }
        [Browsable(false)]
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }
        [Browsable(false)]
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }

        //Privates method
        private void LoadMenuItemAppearance()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Gainsboro;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(25, ItemMenuHieght);

            }
            foreach (ToolStripMenuItem menuItemL1 in this.Items)
            {
                menuItemL1.ForeColor = menuItemTextColor;
                menuItemL1.ImageScaling=ToolStripItemImageScaling.None;
                if(menuItemL1.Image==null)
                {
                    menuItemL1.Image = menuItemHeaderSize;
                }
                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
                {
                    menuItemL2.ForeColor = menuItemTextColor;
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL2.Image == null)
                    {
                        menuItemL2.Image = menuItemHeaderSize;
                    }
                }
            }
        }

        //overrides
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if(this.DesignMode==false)
            {
                LoadMenuItemAppearance();
                this.Renderer= new MenuRenderer(IsMainMenu,PrimaryColor,MenuItemTextColor);
            }
        }
    }
}
