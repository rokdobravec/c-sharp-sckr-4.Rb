using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Enabled = false;
            if (e.ColumnIndex == 0)
            {
                zbirkatekacev[e.RowIndex].Cas = TimeSpan.Parse(label1.Text);
                dataGridView1.Refresh();
            }
        }
        BindingList<Tek100> zbirkatekacev = new BindingList<Tek100>();
        private void Form1_Load(object sender, EventArgs e)
        {
            try 
            { 
                StreamReader sr = File.OpenText("Tekaci.txt");
                string vrstica = sr.ReadLine();
                string[] tab;
                while (vrstica != null)
                {
                    tab = vrstica.Split(';');
                    //ustvarimo objekt tekača
                    Tek100 tekac = new Tek100(tab[0], tab[1], tab[2],
                        Convert.ToChar(tab[3]), Convert.ToDateTime(tab[4]),
                        TimeSpan.FromSeconds(Convert.ToDouble(tab[5])));
                    //dodamo tekaca v zbirko
                    zbirkatekacev.Add(tekac);
                    vrstica = sr.ReadLine();

                  


                }
                sr.Close();
                //Povežemo zbirko z dgv
                dataGridView1.DataSource = zbirkatekacev;
            }
            catch 
            { 
                MessageBox.Show("napaka z datoteko"); 
            }


        }

        private void dodajNovegaTekačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 podobrazec = new Form2();
            if (podobrazec.ShowDialog()==DialogResult.OK)
            {
                Tek100 nov = new Tek100(podobrazec.tb_ime.Text, podobrazec.tb_priimek.Text, podobrazec.tb_drzava.Text,
                    Convert.ToChar(podobrazec.comboBox1.Text), podobrazec.dateTimePicker1.Value.Date, 
                    TimeSpan.FromSeconds(Convert.ToDouble(podobrazec.tb_rekord.Text)));

                //Dodamo tekača v zbirko
                zbirkatekacev.Add(nov);
            }
        }

        private void izbrišiTekačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Potrjujete brisanje tekača "+zbirkatekacev[dataGridView1.CurrentRow.Index].Ime+" "+ 
                zbirkatekacev[dataGridView1.CurrentRow.Index].Priimek+"?","Brisanje",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                zbirkatekacev.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            
        }

        private void popraviPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 podobrazec = new Form2();
            podobrazec.tb_ime.Text = zbirkatekacev[dataGridView1.CurrentRow.Index].Ime;
            podobrazec.tb_priimek.Text = zbirkatekacev[dataGridView1.CurrentRow.Index].Priimek;
            podobrazec.comboBox1.Text = zbirkatekacev[dataGridView1.CurrentRow.Index].Spol.ToString();
            podobrazec.tb_drzava.Text = zbirkatekacev[dataGridView1.CurrentRow.Index].Drzava;
            podobrazec.tb_rekord.Text = zbirkatekacev[dataGridView1.CurrentRow.Index].Cas.ToString();
            podobrazec.dateTimePicker1.Value = zbirkatekacev[dataGridView1.CurrentRow.Index].Datum_rojstva;
            if (podobrazec.ShowDialog() == DialogResult.OK)
            {
                Tek100 nov = new Tek100(podobrazec.tb_ime.Text, podobrazec.tb_priimek.Text, podobrazec.tb_drzava.Text,
                    Convert.ToChar(podobrazec.comboBox1.Text), podobrazec.dateTimePicker1.Value.Date,
                    TimeSpan.FromSeconds(Convert.ToDouble(podobrazec.tb_rekord.Text)));

                //Prepišemo tekača v zbirki
                zbirkatekacev[dataGridView1.CurrentRow.Index] = nov;
            }
        }
        DateTime zacetek;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (DateTime.Now - zacetek).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zacetek = DateTime.Now;
            timer1.Enabled = true;
        }

        private void najhitrejšiTekačToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeSpan mincas = TimeSpan.MaxValue;
            for (int i = 0; i < zbirkatekacev.Count; i++)
            {

                if (zbirkatekacev[i].Cas<mincas)
                {
                    mincas = zbirkatekacev[i].Cas;
                }

            }
            string ljudje="";
            for (int i = 0; i < zbirkatekacev.Count; i++)
            {
                if (zbirkatekacev[i].Cas==mincas)
                {
                    ljudje += zbirkatekacev[i].Ime + " " + zbirkatekacev[i].Priimek+"\n";
                }
            }
            MessageBox.Show("Najhitrejši tekačis časom "+mincas+" so:\n " + ljudje);
        }

        private void shraniPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText("tekaci.txt");
            string vr="";
            for (int i = 0; i < zbirkatekacev.Count; i++)
            {
                vr = zbirkatekacev[i].Ime + ";" +
                   zbirkatekacev[i].Priimek + ";" +
                   zbirkatekacev[i].Drzava + ";" +
                   zbirkatekacev[i].Spol + ";" +
                   zbirkatekacev[i].Datum_rojstva + ";" +
                   zbirkatekacev[i].Cas;
                if (i == zbirkatekacev.Count)//če smo na zadnjem tekaču
                { sw.Write(vr);//zadnjo vrstico v datoteki ne smemo zapisati z metodo writeLine
                    //da nam ne naredi skoka v novo vrstico, ker potem pri nalaganju
                    //podatkov iz datoteke javi napako, ko naleti na to zadnjo prazno vrstico
                }
                else
                { 
                sw.WriteLine(vr);
                }


            }
            sw.Close();
            MessageBox.Show("Podatki so v datoteki tekaci");
        }
    }
    }

