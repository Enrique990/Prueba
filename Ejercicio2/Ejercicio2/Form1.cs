﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbInputX.Text);
                int y = int.Parse(tbInputY.Text);

                listBox1.Items.Clear();

                if (x > y)
                {
                    for (int i = x; i >= y; i--)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                else
                {
                    for (int i = x; i <= y; i++)
                    {
                        listBox1.Items.Add(i);
                    }
                }

                tbInputX.Clear();
                tbInputY.Clear();
            }
            catch(Exception)
            {
                MessageBox.Show("Nuevamente Ingresar X, Y.");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbInputY_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

