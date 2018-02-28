using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Database_Connection_Testing.Class
{
    // ////////////////////////////////////////////////////////////////////////////////////////////////////
    /* 
     * Class Name       :       clsSqlDataModules
     * Description      :       Everything related to configuring the connection string will stored
     *                          in the binary file.
     *                          Database access module can call the ConnectionSting()
     *                          method for full connection string value (with required 
     *                          values), just after the object is constructed.
     * Created by       :       SAI MIN HTET
     * Created date     :       25/Feb/2018
     
     */
    // ////////////////////////////////////////////////////////////////////////////////////////////////////
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
