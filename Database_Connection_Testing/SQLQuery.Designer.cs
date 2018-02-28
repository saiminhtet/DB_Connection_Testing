namespace Database_Connection_Testing
{
    partial class frmSQLQuery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_execute = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_query = new System.Windows.Forms.TextBox();
            this.btn_dbconfig = new System.Windows.Forms.Button();
            this.gpbSearch = new System.Windows.Forms.GroupBox();
            this.gpbSCont = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.gpbSearch.SuspendLayout();
            this.gpbSCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(4, 10);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(75, 23);
            this.btn_execute.TabIndex = 0;
            this.btn_execute.Text = "&Ecexute";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(4, 44);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "&Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_query
            // 
            this.txt_query.Location = new System.Drawing.Point(0, 21);
            this.txt_query.Multiline = true;
            this.txt_query.Name = "txt_query";
            this.txt_query.Size = new System.Drawing.Size(609, 89);
            this.txt_query.TabIndex = 3;
            // 
            // btn_dbconfig
            // 
            this.btn_dbconfig.Location = new System.Drawing.Point(4, 79);
            this.btn_dbconfig.Name = "btn_dbconfig";
            this.btn_dbconfig.Size = new System.Drawing.Size(75, 23);
            this.btn_dbconfig.TabIndex = 4;
            this.btn_dbconfig.Text = "&DB Config";
            this.btn_dbconfig.UseVisualStyleBackColor = true;
            this.btn_dbconfig.Click += new System.EventHandler(this.btn_dbconfig_Click);
            // 
            // gpbSearch
            // 
            this.gpbSearch.Controls.Add(this.gpbSCont);
            this.gpbSearch.Controls.Add(this.txt_query);
            this.gpbSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSearch.Location = new System.Drawing.Point(12, 12);
            this.gpbSearch.Name = "gpbSearch";
            this.gpbSearch.Size = new System.Drawing.Size(705, 121);
            this.gpbSearch.TabIndex = 13;
            this.gpbSearch.TabStop = false;
            this.gpbSearch.Text = "Enter SQL Statements to Search Infomation";
            // 
            // gpbSCont
            // 
            this.gpbSCont.Controls.Add(this.btn_execute);
            this.gpbSCont.Controls.Add(this.btn_dbconfig);
            this.gpbSCont.Controls.Add(this.btn_reset);
            this.gpbSCont.Location = new System.Drawing.Point(615, 10);
            this.gpbSCont.Name = "gpbSCont";
            this.gpbSCont.Size = new System.Drawing.Size(84, 105);
            this.gpbSCont.TabIndex = 59;
            this.gpbSCont.TabStop = false;
            // 
            // dgvResult
            // 
            this.dgvResult.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(12, 129);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(705, 400);
            this.dgvResult.TabIndex = 14;
            // 
            // frmSQLQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 541);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.gpbSearch);
            this.Name = "frmSQLQuery";
            this.Text = "SQLQuery";
            this.gpbSearch.ResumeLayout(false);
            this.gpbSearch.PerformLayout();
            this.gpbSCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_query;
        private System.Windows.Forms.Button btn_dbconfig;
        private System.Windows.Forms.GroupBox gpbSearch;
        private System.Windows.Forms.GroupBox gpbSCont;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}