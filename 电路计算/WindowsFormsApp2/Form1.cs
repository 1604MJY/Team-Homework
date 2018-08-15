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

        private void button1_Click(object sender, EventArgs e)
        {
           
            double V = double.Parse(textBox4.Text);
            double R1 = double.Parse(textBox1.Text);
            double R2 = double.Parse(textBox2.Text);
            double R3= double.Parse(textBox3.Text);
            double R4 = double.Parse(textBox5.Text);
            Circuit circuit=new Circuit(V, R1,R2, R3, R4);
            if (this.radioButton1.Checked == true)
            {//判断是否为空
                double ca1;
                ca1 = Cacu1.Ca1(circuit);
                string output1 = ca1.ToString();
                MessageBox.Show("V= " + textBox4.Text + " R1= " + textBox1.Text + " Ω " + " R2= " + textBox2.Text + " Ω " + " R3= " + textBox3.Text + " Ω " + " R4= " + textBox5.Text + " Ω " + "I = " + output1 + " A");
            }
            else if (this.radioButton2.Checked == true)
            {
                double ca2;
                ca2 = Cacu2.Ca2(circuit);
                string output2 = ca2.ToString();
                MessageBox.Show("V= " + textBox4.Text + " R1= " + textBox1.Text + " Ω " + " R2= " + textBox2.Text + " Ω " + " R3= " + textBox3.Text + " Ω " + " R4= " + textBox5.Text + " Ω " + "I = " + output2 + " A");
            }
            else if (textBox1.Text == "3")
                errorProvider1.SetError(textBox1, "对不起，这里不能为空！");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
