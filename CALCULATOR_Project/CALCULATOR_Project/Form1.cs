using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR_Project
{
    public partial class Form1 : Form
    {
        TinhToan R = new TinhToan();
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {            
            BoxInputOfStack.Text = number1.Text;
            Box.Text = Box.Text + number1.Text;

        }

        private void number2_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number2.Text;
            Box.Text = Box.Text + number2.Text;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number3.Text;
            Box.Text = Box.Text + number3.Text;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number4.Text;
            Box.Text = Box.Text + number4.Text;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number5.Text;
            Box.Text = Box.Text + number5.Text;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number6.Text;
            Box.Text = Box.Text + number6.Text;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number7.Text;
            Box.Text = Box.Text + number7.Text;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number8.Text;
            Box.Text = Box.Text + number8.Text;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number9.Text;
            Box.Text = Box.Text + number9.Text;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = number0.Text;
            Box.Text = Box.Text + number0.Text;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = dot.Text;
            Box.Text = Box.Text + dot.Text;
        }

        private void DauBang_Click(object sender, EventArgs e)// đang xử lý ...........................................
        {
            R.duavaostack(R.Bieuthuc);
            Bieuthuc_hauto.Text = R.Luutrutoanhang.ToString();
             string result = R.tinh();
            Box.Text = result;
            //Box.Text = R.Luutrutoanhang.ToString();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = plusButton.Text;
            Box.Text = Box.Text + plusButton.Text;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = minusButton.Text;
            Box.Text = Box.Text + minusButton.Text;
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = multiButton.Text;
            Box.Text = Box.Text + multiButton.Text;
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = divideButton.Text;
            Box.Text = Box.Text + divideButton.Text;
        }

        private void moNgoac_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = moNgoac.Text;
            Box.Text = Box.Text + moNgoac.Text;
        }

        private void dongNgoac_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = dongNgoac.Text;
            Box.Text = Box.Text + dongNgoac.Text;
        }

        private void xoa1so_Click(object sender, EventArgs e)
        {
            //Box.Text = Box.Text - BoxInputOfStack.Text;
        }

        private void xoaHet_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = null;
            Box.Text = null;
        }

        private void Box_TextChanged(object sender, EventArgs e)// đang xử lý
        {

            
        }

        private void BoxInputOfStack_TextChanged(object sender, EventArgs e)
        {
            R.Trungto = BoxInputOfStack.Text;
            
            R.savegiatribieuthuc(R.Trungto);
             //Bieuthuc_hauto.Text = R.Bieuthuc.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
