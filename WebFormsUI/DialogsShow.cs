using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebFormsUI
{
    public class DialogsShow
    {
        public void DialogShow(string meseeg, Color color)
        {
            Dialog dialog = new Dialog();
            dialog.Width = 400;
            dialog.lblDialog.Text = meseeg;
            dialog.PnlColor.BackColor = color;
            dialog.Show();
        }
    }
}
