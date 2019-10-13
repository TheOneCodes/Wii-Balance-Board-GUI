using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WiiBalanceWalker
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.License = true;
            Close();
        }
        
        private void decline_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.License = false;
            Close();
        }

        private void License_Load(object sender, EventArgs e)
        {

        }
    }
}
