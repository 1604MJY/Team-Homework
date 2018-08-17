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
            AmpCalculator circuitCalc;
            double V = double.Parse(textBox6.Text);
            double R1 = double.Parse(textBox10.Text);
            double R2 = double.Parse(textBox9.Text);
            double R3 = double.Parse(textBox8.Text);
            double R4 = double.Parse(textBox7.Text);
            Circuit circuit = new Circuit(V, R1, R2, R3, R4);
            if (this.图一.Checked == true)
            {
                circuitCalc = new Cacu1(circuit);
                MessageBox.Show("V= " + textBox6.Text + " R1= " + textBox10.Text + " Ω " + " R2= " + textBox9.Text + " Ω " + " R3= " + textBox8.Text + " Ω " + " R4= " + textBox7.Text + " Ω ");
                MessageBox.Show(" I = " + circuitCalc.CalculateAmp().ToString() + " A ");
            }
            else if (this.radioButton3.Checked == true)
            {
                circuitCalc = new Cacu2(circuit);
                MessageBox.Show("V= " + textBox6.Text + " R1= " + textBox10.Text + " Ω " + " R2= " + textBox9.Text + " Ω " + " R3= " + textBox8.Text + " Ω " + " R4= " + textBox7.Text + " Ω ");

                MessageBox.Show(" I = " + circuitCalc.CalculateAmp().ToString() + " A ");
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
            AmpCalculator circuitCalc;
            double V = double.Parse(textBox11.Text);
            double R1 = double.Parse(textBox15.Text);
            double R2 = double.Parse(textBox14.Text);
            double R3 = double.Parse(textBox13.Text);
            double R4 = 0;
            Circuit circuit = new Circuit(V, R1, R2, R3, R4);
            if (this.radioButton6.Checked == true)
            {
                circuitCalc = new Cacu3(circuit);
                MessageBox.Show("V= " + textBox11.Text + " R1= " + textBox15.Text + " Ω " + " R2= " + textBox14.Text + " Ω " + " R3= " + textBox13.Text + " Ω " );
                MessageBox.Show(" I = " + circuitCalc.CalculateAmp().ToString() + " A ");
            }
            else if (this.radioButton5.Checked == true)
            {
                circuitCalc = new Cacu4(circuit);
                MessageBox.Show("V= " + textBox11.Text + " R1= " + textBox15.Text + " Ω " + " R2= " + textBox14.Text + " Ω " + " R3= " + textBox13.Text + " Ω  ");

                MessageBox.Show(" I = " + circuitCalc.CalculateAmp().ToString() + " A ");
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
            e.Handled = textRestrict.restrict(this.textBox10.Text.Length, textBox10.Text.LastIndexOf('.'), e.KeyChar);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textRestrict.restrict(this.textBox9.Text.Length, textBox9.Text.LastIndexOf('.'), e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textRestrict.restrict(this.textBox8.Text.Length, textBox8.Text.LastIndexOf('.'), e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textRestrict.restrict(this.textBox7.Text.Length, textBox7.Text.LastIndexOf('.'), e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textRestrict.restrict(this.textBox6.Text.Length, textBox6.Text.LastIndexOf('.'), e.KeyChar);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textRestrict.restrict(this.textBox15.Text.Length, textBox15.Text.LastIndexOf('.'), e.KeyChar);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textRestrict.restrict(this.textBox14.Text.Length, textBox14.Text.LastIndexOf('.'), e.KeyChar);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textRestrict.restrict(this.textBox13.Text.Length, textBox13.Text.LastIndexOf('.'), e.KeyChar);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = textRestrict.restrict(this.textBox11.Text.Length, textBox11.Text.LastIndexOf('.'), e.KeyChar);
        }


    }
}
