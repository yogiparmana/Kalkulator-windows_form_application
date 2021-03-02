using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        char simbol;
        float angka1,angka2;
        float hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(textBoxkal.Text != string.Empty)
            {
                textBoxkal.Text += "0";
            }
        }

        private void textBoxkal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxkal.Text += "9";
        }

        private void buttonbagi_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(this.textBoxkal.Text);
            simbol = ':';
            textBoxkal.Text += " : ";
        }

        private void buttonkali_Click(object sender, EventArgs e)
        {
            angka1 = float.Parse(this.textBoxkal.Text);
            simbol = 'x';
            textBoxkal.Text += " x ";
        }

        private void buttonkurang_Click(object sender, EventArgs e)
        {
            angka1 = float.Parse(this.textBoxkal.Text);
            simbol = '-';
            textBoxkal.Text += " - ";
        }

        private void buttontambah_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(this.textBoxkal.Text);
            simbol = '+';
            textBoxkal.Text += " + ";
        }

        private void buttonsama_Click(object sender, EventArgs e)
        {
            
            if (this.textBoxkal.Text != string.Empty || simbol == null)
            {

                string[] arr = this.textBoxkal.Text.Split(' ');

                if (arr.Length == 3 && arr[2] != "") 
                {
                    angka2 = int.Parse(arr[2]);
                    switch (simbol)
                    {
                        case '+':
                            hasil = angka1 + angka2;
                            break;
                        case '-':
                            hasil = angka1 - angka2;
                            break;
                        case ':':
                            hasil = angka1 / angka2;
                            break;
                        case 'x':
                            hasil = angka1 * angka2;
                            break;
                        default:
                            break;
                    }
                    textBoxkal.Text = hasil.ToString();
                }
                
            }
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxkal.Text = string.Empty;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxkal.Clear();
        }
    }
}
