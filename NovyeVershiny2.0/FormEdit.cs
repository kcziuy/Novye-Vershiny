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

namespace NovyeVershiny2._0
{
    public partial class FormEdit : Form
    {
        MainForm mf;
        bool nominationChanged = false;
        public FormEdit(MainForm _f)
        {
            mf = _f;
            InitializeComponent();
        }

        private void BtLoad_Click(object sender, EventArgs e)
        {
            Participant prt = new Participant(Convert.ToInt32(prtNumber.Value), mf.f.m_dbConn);
            prt.toEdit(this);
            Update();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSave_Click(object sender, EventArgs e)
        {

            String FName = boxNameF.Text;
            String LName = boxNameL.Text;
            String MName = boxNameM.Text;
            String FNameR = boxNameFR.Text;
            String LNameR = boxNameLR.Text;
            String MNameR = boxNameMR.Text;
            String org = boxOrganization.Text;
            String team = boxTeam.Text;
            int nom = boxNomination.SelectedIndex;

            int age;

            if (boxAge1.Checked)
            {
                age = 1;
            }
            else
            {
                if (boxAge2.Checked)
                {
                    age = 2;
                }
                else
                {
                    age = 3;
                }
            }
            Participant prt = new Participant(FName, LName, MName, FNameR, LNameR, MNameR, org, nom, age, team);
            prt.edit(mf.f.m_sqlCmd, Convert.ToInt32(prtNumber.Value));

            mf.f.m_sqlCmd.CommandText = "UPDATE Participants SET " +
                "res='',out='FALSE' WHERE id='" + prt.id + "'";
            mf.f.m_sqlCmd.ExecuteNonQuery();

            mf.lbLast.Text = Convert.ToString(prt.id);
            this.Close();
        }

        private void BtCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void BoxNomination_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nominationChanged = true;
        }
    }
}
