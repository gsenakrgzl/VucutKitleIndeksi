﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vücutkitleindeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            vki = kilo / (boy * boy);
            label4.Text = vki.ToString();
            if(vki < 18)
            {
                label6.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                label6.Text = "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                label6.Text = "Hafif Kilolu";
            }
            else
            {
                label6.Text = "Obez";
            }
        }
    }
}
