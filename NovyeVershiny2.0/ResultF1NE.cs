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
    public partial class ResultF1NE : Form
    {
        MainForm mf;
        int id;
        private someUsefulThings th;

        public ResultF1NE(MainForm f, int id)
        {
            mf = f;
            this.id = id;
            th = new someUsefulThings();
            InitializeComponent();
        }

        private void ResultF1NE_Load(object sender, EventArgs e)
        {
            ResultTable.RowCount = 2;
            ResultTable.AllowUserToAddRows = false;
            DataTable dTable = new DataTable();
            String sqlQuery = "SELECT * FROM Participants WHERE id='" + id + "'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, mf.f.m_dbConn);
            adapter.Fill(dTable);
            if (th.unparse(dTable.Rows[0].ItemArray[11].ToString()) != null)
            {
                int[] buf = th.unparse(dTable.Rows[0].ItemArray[10].ToString());
                for (int i = 0; i < buf.Length; i++)
                {
                    ResultTable.Rows[0].Cells[i].Value = buf[i];
                }
            }

        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            String export = "";
            for (int i = 0; i < ResultTable.ColumnCount - 1; i++)
            {

                try
                {
                    if (!(ResultTable.Rows[0].Cells[i].Value.ToString() == null))
                    {
                        export += Convert.ToInt32(ResultTable.Rows[0].Cells[i].Value.ToString()) + "-";
                    }

                }
                catch (Exception e1)
                {
                    export += "0-";
                }
            }
            try
            {
                if (!(ResultTable.Rows[0].Cells[ResultTable.Columns.Count - 1].Value.ToString() == null))
                {
                    export += Convert.ToInt32(ResultTable.Rows[0].Cells[ResultTable.Columns.Count - 1].Value.ToString());
                }
            }
            catch (Exception e1)
            {
                export += "0";
            }
            mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                "res='" + export +
                "' WHERE id='" + id + "'";
            mf.f.m_sqlCmd.ExecuteNonQuery();
            this.Close();
        }

        private void ResultTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
