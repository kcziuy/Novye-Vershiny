using Novye;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovyeVershiny2._0
{
    public partial class OutResults : Form
    {
        MainForm mf;
        public OutResults(MainForm f)
        {
            mf = f;
            InitializeComponent();
        }

        private void BoxNomination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            DataTable dTable = new DataTable();
            String sqlQuery;

            if (mf.f.m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }

            try
            {
                dTable.Clear();
                for (int j = 1; j <= 3; j++)
                {
                    sqlQuery = "SELECT age,win,id,fname,lname,mname,team,fnamer,lnamer,mnamer,org FROM Participants WHERE nom ='" + boxNomination.SelectedIndex + "' AND win='" + j + "'";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, mf.f.m_dbConn);
                    
                    adapter.Fill(dTable);
                    if (dTable.Rows.Count > 0)
                    {
                        baseView.Rows.Clear();
                        for (int i = 0; i < dTable.Rows.Count; i++)
                        {
                            baseView.Rows.Add(dTable.Rows[i].ItemArray);
                        }
                    }
                    else
                        MessageBox.Show("Database is empty");
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
