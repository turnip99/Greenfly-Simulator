using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greenfly_Simulator
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (UDYoung.Value > 0 || UDAdult.Value > 0 || UDOld.Value > 0)
            {
                MainForm form = new MainForm(int.Parse(UDYoung.Value.ToString()), int.Parse(UDAdult.Value.ToString()), int.Parse(UDOld.Value.ToString()));
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must create at least one greenfly.");
            }
        }
    }
}
