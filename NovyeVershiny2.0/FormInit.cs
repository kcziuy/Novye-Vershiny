using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novye
{
    public partial class InitForm : Form
    {
        public String dbFileName;
        public SQLiteConnection m_dbConn;
        public SQLiteCommand m_sqlCmd;
        public InitForm()
        {

        InitializeComponent();
        }

        public InitForm rThis() {
            return this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            dbFileName = "base.sqlite";
            lbStatusText.Text = "Disconnected";
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Participants (id INTEGER PRIMARY KEY AUTOINCREMENT,fname TEXT,lname TEXT,mname TEXT,team TEXT,fnamer TEXT,lnamer TEXT,mnamer TEXT,org TEXT,nom INTEGER,age INTEGER,res TEXT, out BIT, win INTEGER)";
                m_sqlCmd.ExecuteNonQuery();

                lbStatusText.Text = "Connected";
            }
            catch (SQLiteException ex)
            {
                lbStatusText.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }

            MainForm f = new MainForm(this);
            f.Visible = true;
        }
    }
}
