using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DashboardGUI
{
    public class MenuColorTable:ProfessionalColorTable
    {
        //field
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        //constructor
        public MenuColorTable(bool isMainMenu,Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = Color.FromArgb(37, 39, 60);
                leftColumnColor = Color.FromArgb(32, 33, 51);
                borderColor = Color.FromArgb(32, 33, 51);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
            else
            {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.FromArgb(32, 33, 51);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
        }

        //override 
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backColor;
            }
        }
        public override Color MenuBorder => borderColor;
        public override Color MenuItemBorder => menuItemBorderColor;
        public override Color MenuItemSelected => menuItemSelectedColor;
        public override Color ImageMarginGradientBegin => leftColumnColor;
        public override Color ImageMarginGradientMiddle => leftColumnColor;
        public override Color ImageMarginGradientEnd => leftColumnColor;
    }
}
