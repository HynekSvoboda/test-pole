using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_pole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(numericUpDown1.Value);
            int[] pole1 = new int[n];
            int[] pole2;
            int[] pole3;
            Random rng = new Random();
            for(int i=0;i<n;i++)
            {
                pole1[i] = rng.Next(33, 127);
            }
            char znak;
            foreach (int i in pole1)
            {
                listBox1.Items.Add(i);
            }
            pole3 = pole1;
            for(int j=0;j<n;j++)
            {
                znak = Convert.ToChar(pole3[j]);
                if ((pole3[j] > 47 && pole3[j] < 58) || (pole3[j] > 64 && pole3[j] < 91) || (pole3[j] > 96 && pole3[j] < 123))
                {
                    listBox3.Items.Add(znak);

                }
            }
            int w = 119; ;
            int prvniporadw = Array.IndexOf(pole3,w);
            int posledniporadw = Array.LastIndexOf(pole3,w);
            if (prvniporadw > -1) label5.Text = Convert.ToString(prvniporadw);
            else label5.Text = "Nenachazi se ";
            if(posledniporadw>-1) label7.Text = Convert.ToString(posledniporadw);
            else label7.Text = "Nenachazi se ";
            pole2 = pole1.Distinct().ToArray();
            foreach(int i in pole2)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
