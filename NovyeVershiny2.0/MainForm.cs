using NovyeVershiny2._0;
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

namespace Novye
{
    public partial class MainForm : Form
    {
        public InitForm f;
        public MainForm(InitForm _f)
        {
            f = _f;
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            f.Visible = false;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormAdd _add = new FormAdd(this);
            _add.boxNomination.SelectedItem = _add.boxNomination.Items[0].ToString();
            _add.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormLook _look = new FormLook(this);
            _look.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FormEdit f = new FormEdit(this);
            f.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AllBaseView f1 = new AllBaseView(this);
            DataTable dTable = new DataTable();
            String sqlQuery;

            if (f.m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }

            try
            {
                sqlQuery = "SELECT * FROM Participants";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, f.m_dbConn);
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    f1.baseView.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        f1.baseView.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("Database is empty");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            f1.Visible = true;
        }

        private void btAddResult_Click(object sender, EventArgs e)
        {
            Result f = new Result(this);
            f.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Вы входите в режим \"на выбывание\". Вы знаете, что делаете?", "Осторожно!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                ElliminationMode f = new ElliminationMode(this);
                f.Visible = true;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OutResults f = new OutResults(this);
            f.Visible = true;
        }
    }
}
