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

        // Numerologi računajo "osebno število" iz datuma rojstva osebe tako, da seštevajo števke rojstnega datuma, dokler ne dobijo
        //enomestnega števila.Na primer, za rojstni datum 19.8.1985 bi dobili število 5, saj je 1+9+8+1+9+8+5 = 41, 4+1 = 5.
        // Na obrazec postavi gumb.Ob kliku na ta gumb naj se v tekstovno datoteko Osebno.txt zapišejo osebna števila za vse dni v letu 2010!

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText("2010.txt");
            string datumi = "";
            for(DateTime datum=Convert.ToDateTime("01.01.2010"); datum <= Convert.ToDateTime("31.12.2010"); datum = datum.AddDays(1))
            {
                datumi += datum.ToShortDateString() + "  " + osebSt(datum) + "\n";
            }
            sw.WriteLine(datumi);
            sw.Close();
            MessageBox.Show("podatki so zapisani v datoteko");

        }
        public int osebSt(DateTime datum)
        {
            string day = datum.Day.ToString();
            string month = datum.Month.ToString();
            string year = datum.Year.ToString();
            int ost = 0;

            for(int i = 0; i<day.Length; i++)
            {
                ost += int.Parse(day[i].ToString());
            }
            for (int i = 0; i < month.Length; i++)
            {
                ost += int.Parse(month[i].ToString());
            }
            for (int i = 0; i < year.Length; i++)
            {
                ost += int.Parse(year[i].ToString());
            }
            while (ost >= 10)
            {
                ost = ost / 10 + ost % 10;
            }
            return ost;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("osebno st je: " + osebSt(dateTimePicker1.Value));
        }
    }
}
