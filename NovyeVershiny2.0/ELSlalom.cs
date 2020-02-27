using Novye;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NovyeVershiny2._0
{
    public partial class ELSlalom : Form
    {
        DataTable dTable;
        String sqlQuery;
        int fullparticipants = 0;
        int nom;
        someUsefulThings th = new someUsefulThings();
        int off = 0;
        int[] participants;
        MainForm mf;
        public ELSlalom(MainForm f, int nomination)
        {
            nom = nomination;
            mf = f;
            InitializeComponent();
        }
        private void BtTourCreate_Click(object sender, EventArgs e)
        {
            dgEdit.Enabled = true;
            dgEdit.Rows.Clear();
            participants = shuffle(participants);
            for (int i = 0; i < (participants.Length) / 2; i++)
            {
                dgEdit.Rows.Add();
                dgEdit.Rows[i].Cells[1].Value = participants[i * 2];
                dgEdit.Rows[i].Cells[2].Value = "Сохранить";
                dgEdit.Rows[i].Cells[3].Value = participants[i * 2 + 1];
            }
            
        }

        public int[] shuffle(int[] inp)
        {
            Random rnd = new Random();
            for (int i = 0; i < inp.Length * inp.Length; i++)
            {
                int a = rnd.Next(0, inp.Length);
                int b = rnd.Next(0, inp.Length);
                int buf;
                buf = inp[a];
                inp[a] = inp[b];
                inp[b] = buf;
            }
            return inp;
        }
        private void ELSlalom_Load(object sender, EventArgs e)
        {
            dgEdit.AllowUserToAddRows = false;
            dgEdit.ReadOnly = false;

            dgEdit.Enabled = false;


            try
            {
                sqlQuery = "SELECT id, res, out FROM Participants WHERE nom ='" + nom + "'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, mf.f.m_dbConn);

                dTable = new DataTable();
                dTable.Clear();
                adapter.Fill(dTable);
                off = 0;
                fullparticipants = dTable.Rows.Count;
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    if (dTable.Rows[i].ItemArray[2].ToString() == "True") { off++; }
                }

                if (dTable.Rows.Count > 0)
                {
                    int onemorebuff = 0;
                    if ((dTable.Rows.Count - off) % 2 == 1)
                    {
                        participants = new int[dTable.Rows.Count - off + 1];
                        participants[dTable.Rows.Count - off] = 0;
                    }
                    else
                    {
                        participants = new int[dTable.Rows.Count - off];
                    }
                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        dTable.Rows[i].ItemArray[1] = th.sum(th.unparse(dTable.Rows[i].ItemArray[1].ToString()));
                        //MessageBox.Show(dTable.Rows[i].ItemArray[2].ToString());
                        if (dTable.Rows[i].ItemArray[2].ToString() == "False")
                        {
                            participants[onemorebuff] = Convert.ToInt32(dTable.Rows[i].ItemArray[0].ToString());
                            onemorebuff++;
                        }
                    }
                    dgView.Rows.Clear();
                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        dgView.Rows.Add(dTable.Rows[i].ItemArray);

                    }
                }
                else
                    MessageBox.Show("Нет невыбывших участников!");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DgEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int prta = Convert.ToInt32(dgEdit.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString());
                int prtb = Convert.ToInt32(dgEdit.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
                bool prtawon = Convert.ToBoolean(dgEdit.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Value);
                bool prtbwon = Convert.ToBoolean(dgEdit.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value);


                mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                    "out='" + !prtawon +
                    "' WHERE id='" + prta + "'";
                mf.f.m_sqlCmd.ExecuteNonQuery();
                mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                    "out='" + !prtbwon +
                    "' WHERE id='" + prtb + "'";
                mf.f.m_sqlCmd.ExecuteNonQuery();
                if (!prtawon)
                {
                    mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                        "win='" + (fullparticipants - off) +
                        "' WHERE id='" + prta + "'";
                    mf.f.m_sqlCmd.ExecuteNonQuery();
                }
                if (!prtbwon)
                {
                    mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                        "win='" + (fullparticipants - off) +
                        "' WHERE id='" + prtb + "'";
                    mf.f.m_sqlCmd.ExecuteNonQuery();
                }
                if (fullparticipants - off == 2) {
                    if (prtawon)
                    {
                        mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                            "win='" + (fullparticipants - off - 1) +
                            "' WHERE id='" + prta + "'";
                        mf.f.m_sqlCmd.ExecuteNonQuery();
                    }
                    if (prtbwon)
                    {
                        mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                            "win='" + (fullparticipants - off - 1) +
                            "' WHERE id='" + prtb + "'";
                        mf.f.m_sqlCmd.ExecuteNonQuery();
                    }
                }
                try
                {
                    sqlQuery = "SELECT id, res, out FROM Participants WHERE nom ='" + nom + "'";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, mf.f.m_dbConn);
                    dTable = new DataTable();
                    adapter.Fill(dTable);
                    off = 0;
                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        if (dTable.Rows[i].ItemArray[2].ToString() == "True") { off++; }
                    }

                    if (dTable.Rows.Count > 0)
                    {
                        int onemorebuff = 0;
                        if ((dTable.Rows.Count - off) % 2 == 1)
                        {
                            participants = new int[dTable.Rows.Count - off + 1];
                            participants[dTable.Rows.Count - off] = 0;
                        }
                        else
                        {
                            participants = new int[dTable.Rows.Count - off];
                        }
                        for (int i = 0; i < dTable.Rows.Count; i++)
                        {
                            dTable.Rows[i].ItemArray[1] = th.sum(th.unparse(dTable.Rows[i].ItemArray[1].ToString()));
                            //MessageBox.Show(dTable.Rows[i].ItemArray[2].ToString());
                            if (dTable.Rows[i].ItemArray[2].ToString() == "False")
                            {
                                participants[onemorebuff] = Convert.ToInt32(dTable.Rows[i].ItemArray[0].ToString());
                                onemorebuff++;
                            }
                        }
                        dgView.Rows.Clear();
                        for (int i = 0; i < dTable.Rows.Count; i++)
                        {
                            dgView.Rows.Add(dTable.Rows[i].ItemArray);

                        }
                    }
                    else
                        MessageBox.Show("Нет невыбывших участников!");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                "out=FALSE, win = ''";
            mf.f.m_sqlCmd.ExecuteNonQuery();
        }
    }

}