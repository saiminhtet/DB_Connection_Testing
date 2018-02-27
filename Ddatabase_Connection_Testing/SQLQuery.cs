using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddatabase_Connection_Testing
{
    public partial class frmSQLQuery : Form
    {
        Class.clsMethods M = new Class.clsMethods();
        Class.clsSQLQuery SQ = new Class.clsSQLQuery();
        DataTable dt = new DataTable();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dtAdpter = new SqlDataAdapter();
        Class.clsSqlDataModules string_connection = new Class.clsSqlDataModules(Application.StartupPath);
        public frmSQLQuery()
        {
            InitializeComponent();
        }

        
        private void btn_execute_Click(object sender, EventArgs e)
        {
            string command = txt_query.Text;
            dt = new DataTable();
            dt = SQ.Query_Result(command);
            dgvResult.DataSource = dt;
        }

        private void btn_dbconfig_Click(object sender, EventArgs e)
        {
            frm_Database_Connection dbc = new frm_Database_Connection();
            dbc.ShowDialog();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            M.TextBox_Clear(txt_query);
            M.DataGridView_Clear(dgvResult);
        }
    }
}
