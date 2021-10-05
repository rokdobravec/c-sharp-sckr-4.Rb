using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vaja1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sporocilnaOknaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void osnovnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void zNapisomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", " napis na oknu");
        }

        private void zDvemaGumbomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Ali zelite izbrisati", "Brisanje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Izbrisano");
            }
            else
            {
                MessageBox.Show("Preknlicano");
            }
        }

        private void sTremiGumbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult odg = MessageBox.Show("Posodobi?", "Window", MessageBoxButtons.YesNoCancel);
            switch(odg)
            {
                case DialogResult.Yes:
                    MessageBox.Show("izbral si Yes");
                    break;
                case DialogResult.No:
                    MessageBox.Show("izbral si No");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("izbral si Cansel");
                    break;
            }
            
            
        }

        private void zIkonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("napaka", "error", MessageBoxButtons.OK , MessageBoxIcon.Error);
        }
    }
}
