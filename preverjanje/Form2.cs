using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double cas = Convert.ToDouble(tb_rekord.Text);

            }
            catch 
            {
                MessageBox.Show("Vnesti morate decimalno število pri času");
                DialogResult = DialogResult.None;
            }
            if (tb_ime.Text == "" || tb_priimek.Text == "" || tb_drzava.Text == "" || tb_rekord.Text == "" || comboBox1.Text == "" ||
                  DateTime.Today.Year - dateTimePicker1.Value.Year < 18)
            {
                MessageBox.Show("Mankajoči podatki.Atlet mora biti polnoleten");
                DialogResult = DialogResult.None;
            }
        }
    }
}
