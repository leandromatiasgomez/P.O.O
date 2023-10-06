using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba3bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            listBox1.Items.Add("A");
            listBox1.Items.Add("AA");
            listBox1.Items.Add("AAA");
            listBox1.Items.Add("AAAA");
            listBox1.Items.Add("AAAAA");
            listBox1.Items.Add("AAAAAA");
            listBox1.Items.Add("AAAAAAA");
            listBox1.Items.Add("AAAAAAAA");
            listBox1.Items.Add("AAAAAAAAA");
            listBox1.Items.Add("AAAAAAAAAA");

            listBox2.Items.Add("B");
            listBox2.Items.Add("BB");
            listBox2.Items.Add("BBB");
            listBox2.Items.Add("BBBB");
            listBox2.Items.Add("BBBBB");
            listBox2.Items.Add("BBBBBB");
            listBox2.Items.Add("BBBBBBB");
            listBox2.Items.Add("BBBBBBBB");
            listBox2.Items.Add("BBBBBBBBB");
            listBox2.Items.Add("BBBBBBBBBB");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p;

            for (int i = 0; i < listBox1.Items.Count && i < listBox2.Items.Count; i++)
            {
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Length <= 5)
                {
                    listBox1.Items.Remove(listBox1.Items[i]);
                }
                if (listBox2.Items[i].ToString().Length <= 5)
                {
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Length <= 5)
                {
                    listBox2.Items.Insert(i, listBox1.Items[i]);
                    listBox1.Items.Remove(listBox1.Items[i]);
                }
                if (listBox2.Items[i].ToString().Length <= 5)
                {
                    listBox1.Items.Insert(i, listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ultimo1 = listBox1.Items.Count ;
            int ultimo2 = listBox2.Items.Count;

            listBox1.Items.Add(listBox2.Items[ultimo2 - 1]);
            listBox2.Items.RemoveAt(ultimo2 - 1);

            listBox2.Items.Add(listBox1.Items[ultimo1 - 1]);
            listBox1.Items.RemoveAt(ultimo1 - 1);;

            int primero = listBox1.Items.Count - (listBox1.Items.Count - 1);
            int primero2 = listBox1.Items.Count - (listBox1.Items.Count - 1);

            listBox1.Items.Insert(primero2 - 1, listBox2.Items[primero2 - 1]);
            listBox2.Items.RemoveAt(primero2 - 1);

            listBox2.Items.Insert(primero -1, listBox1.Items[primero]);
            listBox1.Items.RemoveAt(primero);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
