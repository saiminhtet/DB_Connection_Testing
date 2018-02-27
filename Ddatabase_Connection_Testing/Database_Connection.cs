using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ddatabase_Connection_Testing
{
    public partial class frm_Database_Connection : Form
    {
        private DataSet login = new DataSet();

        Class.clsSqlDataModules sql = new Class.clsSqlDataModules(string.Concat(Application.StartupPath));
        Class.clsMethods Method = new Class.clsMethods();
        public string server, db;
        public frm_Database_Connection()
        {
            InitializeComponent();
            txt_Srv.Text = sql.Server;
            txt_database.Text = sql.DB;
            txt_uname.Text = sql.UserName;
        }

        private bool Validation()
        {
            if (txt_Srv.Text == "")
            {
                MessageBox.Show("You need to enter Server name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Srv.Focus();
                return false;
            }
            else if (txt_database.Text == "")
            {
                MessageBox.Show("You need to enter Database name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_database.Focus();
                return false;
            }
            else if (txt_uname.Text == "")
            {
                MessageBox.Show("You need to enter User Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_uname.Focus();
                return false;
            }
            else if (txt_pwd.Text == "")
            {
                MessageBox.Show("You need to enter Password name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_uname.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Connect()
        {
            using (FileStream read = new FileStream(Application.StartupPath + "\\Login.bin", FileMode.Open))
            {
                BinaryFormatter readformat = new BinaryFormatter();
                login = (DataSet)readformat.Deserialize(read);
                
                login.Tables[0].Clear();
                login.Tables[0].Rows.Add(txt_Srv.Text, txt_database.Text, txt_uname.Text,txt_pwd.Text);
                
                
            }
            login.RemotingFormat = SerializationFormat.Binary;
            File.Delete(Application.StartupPath + "\\Login.bin");
            using (FileStream write = new FileStream(Application.StartupPath + "\\Login.bin", FileMode.Create))
            {
                BinaryFormatter writeformat = new BinaryFormatter();
                writeformat.Serialize(write, login);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                server = txt_Srv.Text;
                db = txt_database.Text;
                Connect();
                //MessageBox.Show("Connect Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Connect Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Method.TextBox_Clear(txt_Srv,txt_database,txt_uname,txt_pwd);
        }

        private void btn_testconn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (Validation() == true)
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=" + txt_Srv.Text + ";Initial Catalog=" + txt_database.Text + ";User ID=" + txt_uname.Text + ";Password=" + txt_pwd.Text);
                    conn.Open();
                    conn.Close();

                    MessageBox.Show("Test Connection Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {

                    MessageBox.Show("Invalid Connection!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
