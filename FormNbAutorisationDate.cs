using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETgesAMM
{
    public partial class FormNbAutorisationDate : Form
    {
        public FormNbAutorisationDate()
        {
            InitializeComponent();
            btnValider.Enabled = false;
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {
            if(tbDate.Text.Length == 10)
            {
                btnValider.Enabled = true;
            }
            else
            {
                btnValider.Enabled = false;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string date = tbDate.Text;
            tbNbAmm.Text = "" + bd.getNbAmmDate(date);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormNbAutorisationDate_Load(object sender, EventArgs e)
        {

        }
    }
}
