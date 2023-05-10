using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string p = textBox2.Text;
            if (p.Length<8)
            {
                label4.Text = "Please Enter 8 Charecter";
            }
            else
            {
                label4.Text = "";
                bool l = false;
                bool u = false;
                bool n = false;
                bool s = false;
                for (int i = 0; i < p.Length; i++)
                {
                    if (char.IsLower(p[i]))
                    {
                        l = true;
                    }else if (char.IsUpper(p[i]))
                    {
                        u= true;
                    }
                    else if (char.IsDigit(p[i]))
                    {
                        n= true;
                    }
                    else
                    {
                        s= true;
                    }
                }
                if (l!=true) {

                    label4.Text = "Please Enter lower";

                }
                else if (u!=true)
                {
                    label4.Text = "Please Enter Upper";

                }else if (n!=true)
                {
                    label4.Text = "Please Enter Number";

                }
                else if(s!=true) 
                {
                    label4.Text = "Please Enter Symbol";

                }
                else
                {
                    if (l==true&&u==true&&n==true&&s==true)
                    {
                        string c = "@yahoo.com";

                        if (x.IndexOf(c) > 0 && x.IndexOf(c) < x.Length - 1)
                        {
                            label5.Text = "";

                            MessageBox.Show("Successfully");
                        }
                        else 
                        {
                            label5.Text = "Write Email";
                        }
                    }
                    
                }
            }

            if (checkBox2.Checked)
            {
                Properties.Settings.Default.rem = textBox1.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.rem = "";
                Properties.Settings.Default.Save();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.rem;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar =false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
