using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AccountingAndSales.Module
{
    public static class PublicMethod
    {
        public static void ClearAllTextboxAndLabelInFactorWindow(StackPanel ContainerPanel)
        {
            foreach (Control ctl in ContainerPanel.Children)
            {
                if (ctl.GetType() == typeof(TextBox))
                    ((TextBox)ctl).Text = string.Empty;

                if (ctl.GetType() == typeof(Label))
                    ((Label)ctl).Content = "0";

            }
        }

    }
}
