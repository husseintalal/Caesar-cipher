using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "\0";
            button1.Text = "Encrypt";
            label1.Text = "Plain Text: ";
            groupBox1.Text = "Encrypt";
            label3.Text = "Encrypted text is: ";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = "Decrypt";
            label1.Text = "Cipher Text: ";
            textBox1.Text = "\0";
            groupBox1.Text = "Decrypt";
            label3.Text = "Decrypted text is: ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x;
            int key;
            if (radioButton1.Checked)
            {
                textBox2.Text = "\0";
                x = textBox1.Text;
                key = Convert.ToInt32(numericUpDown1.Value);
                for (int i = 0; i < x.Length; i++)
                {
                    if (char.IsUpper(x[i]))
                        textBox2.Text+= Convert.ToChar(Convert.ToInt64((x[i] + key - 65) % 26 + 65));
                    else if (char.IsLower(x[i]))
                        textBox2.Text+= Convert.ToChar(Convert.ToInt64((x[i] + key - 97) % 26 + 97));

                }
            }
            else if (radioButton2.Checked)
            {
                char temp;
                textBox2.Text = "\0";
                x = textBox1.Text;
                key = Convert.ToInt32(numericUpDown1.Value);
                for (int i = 0; i < x.Length; i++)
                {
                    if (char.IsUpper(x[i]))
                        textBox2.Text += Convert.ToChar(Convert.ToInt64((x[i] - key + 65) % 26 + 65));
                    else if (char.IsLower(x[i]))
                    {
                        temp=char.ToUpper(x[i]);
                        textBox2.Text += char.ToLower(Convert.ToChar(Convert.ToInt64((temp - key + 65) % 26 + 65)));
                        
                    }
                }  
            }
        }
    }
}
