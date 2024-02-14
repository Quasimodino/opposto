using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void somma_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(txt1.Text);
            txt1.Text = f1.ToString();
            Fraction f2 = Fraction.Parse(txt2.Text);
            txt2.Text = f2.ToString();
            Fraction f3 = f1.Somma(f2);
            tot.Text = f3.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Fraction f4 = Fraction.Parse(txt.Text);
            txt1.Text = f4.ToString();
            lst.Items.Add(f4);
            txt.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
        }

        private void Total_Click(object sender, EventArgs e)
        {
            Fraction s = new Fraction(0, 1);
            foreach (Fraction i in lst.Items)
            {
                s = s + i;
            }
            totale.Text = s.ToString();
        }

        private void opposto_Click(object sender, EventArgs e)
        {
            Fraction f=Fraction.Parse(txt.Text);
            txt.Text= f.ToString();
            Fraction f2 = -(f);
            txt.Clear();
            txt.Text = f2.ToString();
        }
    }
}
