using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void Open_Github(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Quang-Dobe/CS511.M11");
        }
    }
}
