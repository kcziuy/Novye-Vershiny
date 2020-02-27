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
    public partial class FormLook : Form
    {
        MainForm mf;
        public FormLook(MainForm _f)
        {
            mf = _f;
            InitializeComponent();
        }

        private void BtLoad_Click(object sender, EventArgs e)
        {
            Participant prt = new Participant(Convert.ToInt32(prtNumber.Value), mf.f.m_dbConn);
            prt.toLook(this);
            Update();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
