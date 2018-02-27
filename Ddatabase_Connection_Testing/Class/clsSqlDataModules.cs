using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ddatabase_Connection_Testing.Class
{
    class clsSqlDataModules
    {
        //Addributes
        public string Server, DB, UserName, Password;
        private string filepath;
        private string GetDir = "";
        DataSet login = new DataSet();

        //Constructor
        public clsSqlDataModules(string path)
        {
            filepath = path + "\\Login.bin";
            if (File.Exists(filepath))
            {
                refreshCon();
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Server");
                dt.Columns.Add("Database");
                dt.Columns.Add("UserName");
                dt.Columns.Add("Password");
                //foreach (DataRow row in login.Tables[0].Rows)
                //{
                //    DataRow newRow = dt.NewRow();
                //    newRow[0] = "Server";
                //    newRow[0] = "Database";
                //    newRow[0] = "UserName";
                //    newRow[0] = "Password";
                //}
                login.Tables.Add(dt);
                FileStream fs = new FileStream(filepath + GetDir, FileMode.Create);
                BinaryFormatter wfmt = new BinaryFormatter();
                wfmt.Serialize(fs, login);
                fs.Close();
            }
           
        }

        //Properties
        public clsSqlDataModules()
        {
            ConnectionSting();
        }
        public string ConnectionSting()
        {
            refreshCon();
            return string.Format("Server={0};Database={1};uid={2};password={3}", Server, DB, UserName, Password);
        }

        //Method
        private void refreshCon()
        {           
                using (FileStream filestream = new FileStream(filepath + GetDir, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    login = (DataSet)formatter.Deserialize(filestream);
                }
                foreach (DataRow row in login.Tables[0].Rows)
                {
                    Server = row[0].ToString();
                    DB = row[1].ToString();
                    UserName = row[2].ToString();
                    Password = row[3].ToString() == "" ? "" : row[3].ToString();
                }

            
            
        }

        



    }
}
