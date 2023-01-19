/*
 * The name and surname are swaped. 
 * This application swap them back in the right order
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSwap
{
    public partial class frmNameSwap : Form
    {
        public frmNameSwap()
        {
            InitializeComponent();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {

            txtSurname2.Text = txtName1.Text;
            txtName2.Text = txtSurname1.Text;

        }
    }
}
