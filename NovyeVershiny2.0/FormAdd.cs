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
    public partial class FormAdd : Form
    {
        MainForm mf;
        public FormAdd(MainForm f)
        {
            mf = f;
            InitializeComponent();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            String FName = boxNameF.Text;
            String LName = boxNameL.Text;
            String MName = boxNameM.Text;
            String FNameR = boxNameFR.Text;
            String LNameR = boxNameLR.Text;
            String MNameR = boxNameMR.Text;
            String Team = boxTeam.Text;
            String org = boxOrganization.Text;
            int nom = boxNomination.SelectedIndex;

            int age;

            if (boxAge1.Checked) {
                age = 1;
            }
            else {
                if (boxAge2.Checked) {
                    age = 2;
                }
                else {
                    age = 3;
                }
            }

            Participant prt = new Participant(FName, LName, MName, FNameR, LNameR, MNameR, org, nom, age, Team);

            prt.save(mf.f.m_sqlCmd, mf.f.m_dbConn);
            mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                "res='',out='FALSE' WHERE id='" + prt.id + "'";
            mf.f.m_sqlCmd.ExecuteNonQuery();
            mf.lbLast.Text = Convert.ToString(prt.id);
            this.Close();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void BoxNomination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void BoxOrganization_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    public class Participant
    {

        public String FName, LName, MName, FNameR, LNameR, MNameR, org, team;
        public int nom, age, id;

        public Participant(int value, SQLiteConnection conn)
        {
            id = value;

            DataTable dTable = new DataTable();
            String sqlQuery;

            sqlQuery = "SELECT * FROM Participants WHERE id = " + id;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, conn);
            adapter.Fill(dTable);

            try
            {
                id = Convert.ToInt32(dTable.Rows[0].ItemArray[0].ToString());
                FName = dTable.Rows[0].ItemArray[1].ToString();
                LName = dTable.Rows[0].ItemArray[2].ToString();
                MName = dTable.Rows[0].ItemArray[3].ToString();
                team = dTable.Rows[0].ItemArray[4].ToString();
                FNameR = dTable.Rows[0].ItemArray[5].ToString();
                LNameR = dTable.Rows[0].ItemArray[6].ToString();
                MNameR = dTable.Rows[0].ItemArray[7].ToString();
                org = dTable.Rows[0].ItemArray[8].ToString();
                nom = Convert.ToInt32(dTable.Rows[0].ItemArray[9].ToString());
                age = Convert.ToInt32(dTable.Rows[0].ItemArray[10].ToString());
            }
            catch (Exception e) {
                MessageBox.Show("Ошибка при загрузке участника!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Participant(String _FName, String _LName, String _MName, String _FNameR, String _LNameR, String _MNameR, String _org, int _nomination, int _age, String _team)
        {
            FName = _FName;
            LName = _LName;
            MName = _MName;
            FNameR = _FNameR;
            LNameR = _LNameR;
            MNameR = _MNameR;
            org = _org;
            nom = _nomination;
            age = _age;
            team = _team;
        }

        public void toLook(FormLook f)
        {
            f.boxNameF.Text = FName;
            f.boxNameL.Text = LName;
            f.boxNameM.Text = MName;
            f.boxNameFR.Text = FNameR;
            f.boxNameLR.Text = LNameR;
            f.boxNameMR.Text = MNameR;
            f.boxOrganization.Text = org;
            f.boxNomination.Text = f.boxNomination.Items[nom].ToString();
            f.boxAge1.Checked = false;
            f.boxAge2.Checked = false;
            f.boxAge3.Checked = false;
            f.boxTeam.Text = team;
            switch (age)
            {
                case 1: f.boxAge1.Checked = true; break;
                case 2: f.boxAge2.Checked = true; break;
                default: f.boxAge3.Checked = true; break;
            }
        }

        public void toEdit(FormEdit f)
        {
            f.boxNameF.Text = FName;
            f.boxNameL.Text = LName;
            f.boxNameM.Text = MName;
            f.boxNameFR.Text = FNameR;
            f.boxNameLR.Text = LNameR;
            f.boxNameMR.Text = MNameR;
            f.boxOrganization.Text = org;
            f.boxNomination.Text = f.boxNomination.Items[nom].ToString();
            f.boxAge1.Checked = false;
            f.boxAge2.Checked = false;
            f.boxAge3.Checked = false;
            switch (age)
            {
                case 1: f.boxAge1.Checked = true; break;
                case 2: f.boxAge2.Checked = true; break;
                default: f.boxAge3.Checked = true; break;
            }

        }


        public void edit(SQLiteCommand com, int id)
        {
            this.id = id;
            try
            {
                com.CommandText = "UPDATE Participants SET " +
                    "fname='" +   FName + 
                    "', lname='" +   LName +
                    "', mname='" + MName +
                    "', team='" + team +
                    "', fnameR='" +   FNameR + 
                    "', lnameR='" +   LNameR + 
                    "', mnameR='" +   MNameR + 
                    "', org='" +   org + 
                    "', nom='" +     nom + 
                    "', age='" +     age + 
                    "' WHERE id=" + id + "";

                com.ExecuteNonQuery();

                MessageBox.Show("Номер участника: " + id, "Участник сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    
        public void save(SQLiteCommand com, SQLiteConnection conn)
        {

            try
            {
                com.CommandText = "INSERT INTO Participants('fname','lname','mname','team','fnamer','lnamer','mnamer','org','nom','age') values ('" +
                    FName + "' , '" +
                    LName + "' , '" +
                    MName + "' , '" +
                    team + "' , '" +
                    FNameR + "' , '" +
                    LNameR + "' , '" +
                    MNameR + "' , '" +
                    org + "' , '" +
                    nom + "' , '" +
                    age + "')";

                com.ExecuteNonQuery();

                DataTable dTable = new DataTable();
                String sqlQuery;


                sqlQuery = "SELECT * FROM Participants";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, conn);
                adapter.Fill(dTable);

                id = dTable.Rows.Count;

                MessageBox.Show("Номер участника: " + id, "Участник сохранен", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

    }
}
