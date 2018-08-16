using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{ 
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            double V = double.Parse(textBox6.Text);
            double R1 = double.Parse(textBox10.Text);
            double R2 = double.Parse(textBox9.Text);
            double R3 = double.Parse(textBox8.Text);
            double R4 = double.Parse(textBox7.Text);
            Circuit circuit = new Circuit(V, R1, R2, R3, R4);
            if (this.图一.Checked == true)
            {//判断是否为空
                double ca1;
                ca1 = Cacu1.Ca1(circuit);
                string output1 = ca1.ToString();
                MessageBox.Show("V= " + textBox6.Text + " R1= " + textBox10.Text + " Ω " + " R2= " + textBox9.Text + " Ω " + " R3= " + textBox8.Text + " Ω " + " R4= " + textBox7.Text + " Ω " + "I = " + output1 + " A");
            }
            else if (this.radioButton3.Checked == true)
            {
                double ca2;
                ca2 = Cacu2.Ca2(circuit);
                string output2 = ca2.ToString();
                MessageBox.Show("V= " + textBox6.Text + " R1= " + textBox10.Text + " Ω " + " R2= " + textBox9.Text + " Ω " + " R3= " + textBox8.Text + " Ω " + " R4= " + textBox7.Text + " Ω " + "I = " + output2 + " A");
            }
            else if (this.radioButton3.Checked == false && this.图一.Checked == false)
                errorProvider1.SetError(radioButton3, "请选择电路类型！");

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            double V = double.Parse(textBox11.Text);
            double R1 = double.Parse(textBox15.Text);
            double R2 = double.Parse(textBox14.Text);
            double R3 = double.Parse(textBox13.Text);
            double R4 = double.Parse(textBox12.Text);
            Circuit circuit = new Circuit(V, R1, R2, R3, R4);
            if (this.radioButton6.Checked == true)
            {
                double ca1;
                ca1 = Cacu3.Ca3(circuit);
                string output1 = ca1.ToString();
                MessageBox.Show("V= " + textBox11.Text + " R1= " + textBox15.Text + " Ω " + " R2= " + textBox14.Text + " Ω " + " R3= " + textBox13.Text + " Ω " + " R4= " + textBox12.Text + " Ω " + "I = " + output1 + " A");
            }
            else if (this.radioButton5.Checked == true)
            {
                double ca2;
                ca2 = Cacu4.Ca4(circuit);
                string output2 = ca2.ToString();
                MessageBox.Show("V= " + textBox11.Text + " R1= " + textBox15.Text + " Ω " + " R2= " + textBox14.Text + " Ω " + " R3= " + textBox13.Text + " Ω " + " R4= " + textBox12.Text + " Ω " + "I = " + output2 + " A");
            }
            else if (this.radioButton5.Checked == false && this.radioButton6.Checked == false)
                errorProvider1.SetError(radioButton5, "请选择电路类型！");

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox10.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox10.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox9.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox9.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox8.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox8.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox7.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox7.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox6.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox6.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox15.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox15.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox14.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox14.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox13.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox13.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox12.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox12.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符  
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.' || this.textBox11.Text.Length == 0)//小数点  
                {
                    e.Handled = true;
                }
                if (textBox11.Text.LastIndexOf('.') != -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
