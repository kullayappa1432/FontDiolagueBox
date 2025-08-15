using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace fontdilogbox
{
    public partial class Form1 : Form
    {
        String fname = "Microsoft Sans Serif";
        float fsize = 10;
        string fstyle ="Regular";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection col = new InstalledFontCollection();
            foreach (FontFamily f in col.Families)
            {
                comboBox1.Items.Add(f.Name);
            }
            for (int i = 6; i < 100; i++)
            {
                comboBox3.Items.Add(i);
            }
    

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string fname = comboBox1.Text;
            float fsize = float.Parse(comboBox3.Text);
            string fstyle = comboBox2.Text;

            if (fstyle == "Regular")
            {
                Font f = new Font(fname, fsize, FontStyle.Regular);
                diolagueText.Font = f;
            }

            if (fstyle == "Bold")
            {
                Font f = new Font(fname, fsize, FontStyle.Bold);
                diolagueText.Font = f;
            }

            if (fstyle == "Italic")
            {
                Font f = new Font(fname, fsize, FontStyle.Italic);
                diolagueText.Font = f;
            }
            if (fstyle == "Bold Italic")
            {
                Font f = new Font(fname, fsize, FontStyle.Strikeout);
                diolagueText.Font = f;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fname = comboBox1.Text;
            float fsize = float.Parse(comboBox3.Text);
            string fstyle = comboBox2.Text;

            if (fstyle == "Regular")
            {
                Font f = new Font(fname, fsize, FontStyle.Regular);
                diolagueText.Font = f;
            }

            if (fstyle == "Bold")
            {
                Font f = new Font(fname, fsize, FontStyle.Bold);
                diolagueText.Font = f;
            }

            if (fstyle == "Italic")
            {
                Font f = new Font(fname, fsize, FontStyle.Italic);
                diolagueText.Font = f;
            }
            if (fstyle == "Bold Italic")
            {
                Font f = new Font(fname, fsize, FontStyle.Strikeout);
                diolagueText.Font = f;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fname = comboBox1.Text;
            float fsize = float.Parse(comboBox3.Text);
            string fstyle = comboBox2.Text;

            if (fstyle == "Regular")
            {
                Font f = new Font(fname, fsize, FontStyle.Regular);
                diolagueText.Font = f;
            }

            if (fstyle == "Bold")
            {
                Font f = new Font(fname, fsize, FontStyle.Bold);
                diolagueText.Font = f;
            }

            if (fstyle == "Italic")
            {
                Font f = new Font(fname, fsize, FontStyle.Italic);
                diolagueText.Font = f;
            }
            if (fstyle == "Bold Italic")
            {
                Font f = new Font(fname, fsize, FontStyle.Strikeout);
                diolagueText.Font = f;
            }
           
        }
    }
}
