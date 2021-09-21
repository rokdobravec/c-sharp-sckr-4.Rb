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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("padavine.txt");
            string vrstica = sr.ReadLine();
            string[] tab;
            string izp = "";
            while(vrstica!=null)
            {
                tab = vrstica.Split('|');
                izp += tab[0] + "kolicina padavin:" + tab[1] + "\n";
                vrstica = sr.ReadLine();
            }
            sr.Close();
            MessageBox.Show(izp);
        }
    }
}
