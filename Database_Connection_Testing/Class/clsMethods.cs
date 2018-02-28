using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Connection_Testing.Class
{
    public class clsMethods
    {
        public void TextBox_Enable(bool Enable, params TextBox[] txt)
        {
            foreach (TextBox mytxt in txt)
            {
                mytxt.Enabled = Enable;
            }
        }

        public void TextBox_Clear(params TextBox[] txt)
        {
            foreach (TextBox mytxt in txt)
            {
                mytxt.ResetText();
            }
        }

        public void DataGridView_Clear(params DataGridView[] dgv)
        {
            foreach (DataGridView mydgv in dgv)
            {
                if (mydgv.DataSource != null)
                {
                    mydgv.DataSource = null;
                }
                else
                {
                    mydgv.Rows.Clear();
                }
            }
        }


    }
}
