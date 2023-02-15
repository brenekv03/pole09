using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pole09
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
            listBox3.Items.Clear();
            int n = int.Parse(textBox1.Text);
            int[] pole = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int cislo = rnd.Next(1, 21);
                pole[i] = cislo;
            }
            Array.Sort(pole);
            foreach (int x in pole)
            {
                listBox1.Items.Add(x);
            }
            int b = int.Parse(textBox2.Text);
            int[] pole2;

            //umístění b
            int pocetMensichNeboRovnoB = 0;
            for(int i = 0; i < n;i++)
            {
                if (pole[i] <= b) pocetMensichNeboRovnoB++;
                else break;
            }
            pole2=pole.Take(pocetMensichNeboRovnoB).ToArray();
            foreach (int x in pole2)
            {
                listBox2.Items.Add(x);
            }
            int[] pole3;
            pole3 = pole.Skip(pocetMensichNeboRovnoB).ToArray();
            foreach (int x in pole3)
            {
                listBox3.Items.Add(x);
            }
        }
    }
}
