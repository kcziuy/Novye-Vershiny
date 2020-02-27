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
using NovyeVershiny2;

namespace NovyeVershiny2._0
{
    public partial class ResultHLG : Form
    {
        MainForm mf;
        int id;
        private someUsefulThings th;

        public ResultHLG(MainForm f, int id)
        {
            mf = f;
            th = new someUsefulThings();
            this.id = id;
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultHLG_Load(object sender, EventArgs e)
        {
            ResultTable.RowCount = 2;
            ResultTable.AllowUserToAddRows = false;
            DataTable dTable = new DataTable();
            String sqlQuery = "SELECT * FROM Participants WHERE id='" + id + "'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, mf.f.m_dbConn);
            adapter.Fill(dTable);
            if (th.unparse(dTable.Rows[0].ItemArray[11].ToString()) != null){
                int[] buf = th.unparse(dTable.Rows[0].ItemArray[11].ToString());
                for (int j = 0; j < dTable.Rows.Count; j++)
                {
                    for (int i = 0; i < buf.Length; i++)
                    {
                        ResultTable.Rows[j].Cells[i].Value = buf[j*dTable.Rows.Count + i];
                    }
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

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
