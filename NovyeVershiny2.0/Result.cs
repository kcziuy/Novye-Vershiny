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
    public partial class Result : Form
    {
        MainForm mf;
        someUsefulThings th;
        public Result(MainForm mf)
        {
            this.mf = mf;
            th = new someUsefulThings();
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            Participant prt = new Participant(Convert.ToInt32(prtNumber.Value), mf.f.m_dbConn);
            switch (prt.nom)
            {
                case 0:
                case 1:
                    ResultHLG f = new ResultHLG(mf, Convert.ToInt32(prtNumber.Value));
                    f.Visible = true;
                    break;
                case 2: 
                    ResultF1NE f1 = new ResultF1NE(mf, Convert.ToInt32(prtNumber.Value));
                    f1.Visible = true;
                    break;
                case 3:
                    ResultEASY f2 = new ResultEASY(mf, Convert.ToInt32(prtNumber.Value));
                    f2.Visible = true;
                    break;
                case 4:
                    ResultRadio f3 = new ResultRadio(mf, Convert.ToInt32(prtNumber.Value));
                    f3.Visible = true;
                    break;
                case 5: 
                    ResultCord1 f4 = new ResultCord1(mf, Convert.ToInt32(prtNumber.Value));
                    f4.Visible = true;
                    break;
                case 6:
                    ResultCord2 f5 = new ResultCord2(mf, Convert.ToInt32(prtNumber.Value));
                    f5.Visible = true;
                    break;
                case 7:
                    ResultDrone1 f6 = new ResultDrone1(mf, Convert.ToInt32(prtNumber.Value));
                    f6.Visible = true;
                    break;
                case 8: 
                    ResultDrone2 f7 = new ResultDrone2(mf, Convert.ToInt32(prtNumber.Value));
                    f7.Visible = true;
                    break;
            }

        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            int nom = boxNomination.SelectedIndex;
            String sqlQuery = "SELECT id, res FROM Participants WHERE nom =" + nom;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, mf.f.m_dbConn);
            adapter.Fill(dTable);
            int[] ids = new int[dTable.Rows.Count];
            float[] sums = new float[dTable.Rows.Count];
            for (int i = 0; i < dTable.Rows.Count; i++) {
                ids[i] = Convert.ToInt32(dTable.Rows[i].ItemArray[0]);
                if (nom > 6)
                {
                    sums[i] = th.sum(th.unparse(dTable.Rows[i].ItemArray[1].ToString(), 1));
                }
                else {
                    sums[i] = th.sum(th.unparse(dTable.Rows[i].ItemArray[1].ToString()));
                }
            }
            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                for (int j = 0; j < dTable.Rows.Count; j++)
                {
                    if (sums[i] < sums[j]) {
                        float tmp = sums[i];
                        sums[i] = sums[j];
                        sums[j] = tmp;
                        tmp = ids[i];
                        ids[i] = ids[j];
                        ids[j] = Convert.ToInt32(tmp);
                    }
                }
            }
            for (int i = 0; i < dTable.Rows.Count;i++)
            {
                mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                    "win='" + (dTable.Rows.Count-i) +"',out='TRUE' WHERE id='" + ids[i] + "'";
                mf.f.m_sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
