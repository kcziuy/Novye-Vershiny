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
    public partial class AllBaseView : Form
    {
        MainForm mf;
        public AllBaseView(MainForm mf)
        {
            this.mf = mf;
            InitializeComponent();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BaseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
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
                sqlQuery = "SELECT * FROM Participants";
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
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AllBaseView_Load(object sender, EventArgs e)
        {

        }
    }
}
