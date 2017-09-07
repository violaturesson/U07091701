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

namespace upgB
{
    public partial class Form1 : Form

    {
        //Arra5yLists
        ArrayList kunder = new ArrayList();
        ArrayList temp = new ArrayList();
        ArrayList bas = new ArrayList();

        //Variables
        int min = 200;
        Customer kund;

        public Form1()
        {
            InitializeComponent();

            //Labels & Buttons
            label1.Text = "Välj sorteringssätt: ";
            label2.Text = "Förnamn";
            label3.Text = "Efternamn";
            label4.Text = "Telefonnummer";
            label5.Text = "Stad";

            button1.Text = "Förnamn";
            button2.Text = "Efternamn";
            button3.Text = "Stad";
            button4.Text = "Spara";

        }

        //Sort Fnamn
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length = bas.Count;

            //Find smallest number (first char)
            for (int i = 0; i < length; i++)
            {

                foreach (Customer c in kunder)
                {
                    if (Convert.ToInt32(c.Fnamn[0]) < min)
                    {
                        min = Convert.ToInt32(c.Fnamn[0]);
                        kund = c;
                    }
                }

                //Remove kund
                min = 200;
                temp.Add(new Customer());
                temp[i] = kund;
                kunder.Remove(kund);
            }

            //Add to listBox1
            foreach (Customer c in temp)
            {
                listBox1.Items.Add(c.Fnamn + " " + c.Enamn + " " + c.Tel + " " + c.Stad);
            }

            //Add kunder from temp
            for (int i = 0; i < temp.Count-1; i++)
            {
                kunder.Add(new Customer());
                kunder[i] = bas[i];
                temp.Remove(temp[i]);
            }
        }

        //Sort Enamn
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length = bas.Count;

            //Find smallest number (first char)
            for (int i = 0; i < length; i++)
            {

                foreach (Customer c in kunder)
                {
                    if (Convert.ToInt32(c.Enamn[0]) < min)
                    {
                        min = Convert.ToInt32(c.Enamn[0]);
                        kund = c;
                    }
                }

                //Remove kund
                min = 200;
                temp.Add(new Customer());
                temp[i] = kund;
                kunder.Remove(kund);
            }

            //Add to listBox2
            foreach (Customer c in temp)
            {
                listBox1.Items.Add(c.Fnamn + " " + c.Enamn + " " + c.Tel + " " + c.Stad);
            }

            //Add kunder from temp
            for (int i = 0; i < temp.Count-1; i++)
            {
                kunder.Add(new Customer());
                kunder[i] = bas[i];
                temp.Remove(temp[i]);
            }
        }

        //Sort Stad
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length = bas.Count;

            //Find smallest number (first char)
            for (int i = 0; i < length; i++)
            {

                foreach (Customer c in kunder)
                {
                    if (Convert.ToInt32(c.Stad[0]) < min)
                    {
                        min = Convert.ToInt32(c.Stad[0]);
                        kund = c;
                    }
                }

                //Remove kund
                min = 200;
                temp.Add(new Customer());
                temp[i] = kund;
                kunder.Remove(kund);
            }

            //Add to listBox3
            foreach (Customer c in temp)
            {
                listBox1.Items.Add(c.Fnamn + " " + c.Enamn + " " + c.Tel + " " + c.Stad);
            }

            //Add kunder from temp
            for (int i = 0; i < temp.Count-1; i++)
            {
                kunder.Add(new Customer());
                kunder[i] = bas[i];
                temp.Remove(temp[i]);
            }
        }
        
        //Save Customer
        private void button4_Click(object sender, EventArgs e)
        {
            kunder.Add(new Customer() { Fnamn = textBox1.Text,
                                        Enamn = textBox2.Text,
                                        Tel = int.Parse(textBox3.Text),
                                        Stad = textBox4.Text });
            bas.Add(new Customer()  { Fnamn = textBox1.Text,
                                      Enamn = textBox2.Text,
                                      Tel = int.Parse(textBox3.Text),
                                      Stad = textBox4.Text
            });
        }
    }
}
