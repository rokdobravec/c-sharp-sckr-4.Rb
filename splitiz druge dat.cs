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
            try
            {
                StreamReader beri = File.OpenText("avtorji.txt");
                string vrstica = beri.ReadLine();
                string[] tabelca = vrstica.Split(';');
                while (vrstica != null)
                {
                    tabelca = vrstica.Split(';');
                    MessageBox.Show(tabelca[0] + "\n" + tabelca[1] + "\nLetnica rojstva: " +
                        tabelca[2] + "\n" + tabelca[3]);
                    vrstica = beri.ReadLine();
                }
                beri.Close();
            }
        }
    }
}
