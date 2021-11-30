using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_probability
{
    public partial class Form1 : Form
    {
        float A;
        float B;
        float C;
        float D;
        float E;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = float.Parse(textBox1.Text);
            B = float.Parse(textBox2.Text);
            C = float.Parse(textBox3.Text);
            //VALUES ARE TAKEN ABOVE...
            textBox1.Text = (A / (A + B + C)).ToString();
            //FORMULA FOR PROBABILITY
            textBox2.Text = (B / (A + B + C)).ToString();
            textBox3.Text = (C / (A + B + C)).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            //thos will clear the probability holding fields

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            //input holding fields will be cleared by this
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int k, m;
            double perm, comb;
            k = Convert.ToInt32(textBox4.Text);
            m = Convert.ToInt32(textBox5.Text);

            perm = fac(k) / fac(k - m);

            comb = fac(k) / (fac(k - m) * fac(k));

            PER.Text = Convert.ToString(perm);
            COMBI.Text = Convert.ToString(comb);


        }
        int fac(int a)
        {
            int i, fa = 1;
            for (i = 0; i <= a; i++)
            { fa *= i; }
            return fa;
        } 

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PERMU_Click(object sender, EventArgs e)
        {

        }

        private void JJ_Click(object sender, EventArgs e)
        {

        }
    }
}
