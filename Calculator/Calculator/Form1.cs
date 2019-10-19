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

namespace Calculator
{
    public partial class Form1 : Form
    {
        public void Check(Stack MyStackInfix)
        {

        }
        Stack MyStackInfix = new Stack();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button1.Text;
            MyStackInfix.Push(button1.Text);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button2.Text;
            MyStackInfix.Push(button2.Text);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button3.Text;
            MyStackInfix.Push(button3.Text);
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button4.Text;
            MyStackInfix.Push(button4.Text);
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button5.Text;
            MyStackInfix.Push(button5.Text);
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button6.Text;
            MyStackInfix.Push(button6.Text);
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button7.Text;
            MyStackInfix.Push(button7.Text);
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button8.Text;
            MyStackInfix.Push(button8.Text);
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button9.Text;
            MyStackInfix.Push(button9.Text);
        }
        private void Button10_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button10.Text;
            MyStackInfix.Push(button10.Text);
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button11.Text;
            MyStackInfix.Push(button11.Text);
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + button13.Text + " ";
            MyStackInfix.Push(button13.Text);
        }
        private void Button14_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + button14.Text + " ";
            MyStackInfix.Push(button14.Text);
        }
        private void Button15_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + button15.Text + " ";
            MyStackInfix.Push(button15.Text);
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + " " + button16.Text + " ";
            MyStackInfix.Push(button16.Text);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button17.Text;
            MyStackInfix.Push(button17.Text);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + button18.Text;
            MyStackInfix.Push(button18.Text);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            textBox.Text = null;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button21_Click(object sender, EventArgs e)
        {

        }

        private void Button19_Click(object sender, EventArgs e)
        {

        }
    }
}
