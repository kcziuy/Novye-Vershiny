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
    public partial class ElliminationMode : Form
    {
        MainForm mf;
        public ElliminationMode(MainForm f)
        {
            mf = f;
            InitializeComponent();
        }

        private void BtSlalom_Click(object sender, EventArgs e)
        {
            ELSlalom f = new ELSlalom(mf, 7);
            f.Visible = true;
        }

        private void BtFPV_Click(object sender, EventArgs e)
        {

            ELSlalom f = new ELSlalom(mf, 8);
            f.Visible = true;
        }
    }
}
