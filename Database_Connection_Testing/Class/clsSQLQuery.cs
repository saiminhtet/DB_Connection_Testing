using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Connection_Testing.Class
{
    class clsSQLQuery
    {
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;
        clsSqlDataModules sql = new clsSqlDataModules(Application.StartupPath);

        #region "Property"
        string _Command;
        public string Command
        {
            get { return _Command; }
            set { _Command = value; }
        }
        #endregion
        #region "Execute Query"
        public DataTable Query_Result(string command)
        {           
            dt = new DataTable();
            da = new SqlDataAdapter();
            cmd = new SqlCommand(command, new SqlConnection(sql.ConnectionSting()));
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        #endregion

    }
}
