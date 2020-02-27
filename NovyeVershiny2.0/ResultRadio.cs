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
    public partial class ResultRadio : Form
    {

        MainForm mf;
        int id;
        someUsefulThings th;

        public ResultRadio(MainForm f, int id)
        {

            mf = f;
            this.id = id;
            th = new someUsefulThings();
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            String export = "";
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < ResultTable.ColumnCount; i++)
                {

                    try
                    {
                        if (!(ResultTable.Rows[j].Cells[i].Value.ToString() == null))
                        {
                            export += Convert.ToInt32(ResultTable.Rows[j].Cells[i].Value.ToString()) + "-";
                        }

                    }
                    catch (Exception e1)
                    {
                        export += "0-";
                    }
                }
            }
            export = export.Remove(export.Length - 1);
            mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                "res='" + export +
                "' WHERE id='" + id + "'";
            mf.f.m_sqlCmd.ExecuteNonQuery();
            this.Close();


        }

        private void ResultTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ResultRadio_Load(object sender, EventArgs e)
        {
            ResultTable.RowCount = 4;
            
            ResultTable.AllowUserToAddRows = false;
            DataTable dTable = new DataTable();
            String sqlQuery = "SELECT * FROM Participants WHERE id='" + id + "'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, mf.f.m_dbConn);
            adapter.Fill(dTable);
            try
            {
                if (th.unparse(dTable.Rows[0].ItemArray[11].ToString()) != null)
                {
                    int[] buf = th.unparse(dTable.Rows[0].ItemArray[11].ToString());
                    for (int j = 0; j < ResultTable.Rows.Count; j++)
                    {
                        for (int i = 0; i < (buf.Length/3); i++)
                        {
                            ResultTable.Rows[j].Cells[i].Value = buf[j * ResultTable.ColumnCount + i];
                        }
                    }
                }
            }
            catch (Exception e3) {
               
            }
        }
    }
}
