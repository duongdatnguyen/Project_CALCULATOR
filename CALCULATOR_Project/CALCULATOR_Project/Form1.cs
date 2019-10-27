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
        int loidau = 0;
        int kiemtra = 0;
        TinhToan R = new TinhToan();
        LuuTru K = new LuuTru();
        public static string result;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void number1_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number1.Text;
            Box.Text = Box.Text + number1.Text;
        }

        private void xoaHet_Click()
        {
            throw new NotImplementedException();
        }

        private void number2_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number2.Text;
            Box.Text = Box.Text + number2.Text;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number3.Text;
            Box.Text = Box.Text + number3.Text;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number4.Text;
            Box.Text = Box.Text + number4.Text;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number5.Text;
            Box.Text = Box.Text + number5.Text;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number6.Text;
            Box.Text = Box.Text + number6.Text;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number7.Text;
            Box.Text = Box.Text + number7.Text;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number8.Text;
            Box.Text = Box.Text + number8.Text;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number9.Text;
            Box.Text = Box.Text + number9.Text;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            loidau = 0;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = number0.Text;
            Box.Text = Box.Text + number0.Text;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = dot.Text;
            Box.Text = Box.Text + dot.Text;
            loidau++;
            if (loidau == 2)
            {
                MessageBox.Show("Lỗi phép tính", "Math Error!");
                KetQuaBieuThuc.Text = "error";
            }
        }

        public void DauBang_Click(object sender, EventArgs e)// đang xử lý ...........................................
        {
            R.duavaostack(R.Bieuthuc);
            //Bieuthuc_hauto.Text = R.Luutrutoanhang.ToString();
            Bieuthuc_hauto.Text = R.ST;
            //Bieuthuc_hauto.Text = K.KT;
            if (kiemtra == 1 || kiemtra == -1)
            {
                MessageBox.Show("Lỗi dấu ngoặc", "Warning!");
                KetQuaBieuThuc.Text = "error";
            }
            else
            {
                result = R.tinh();
                if (result == "error")
                    KetQuaBieuThuc.Text = result;
                else
                    KetQuaBieuThuc.Text = "=" + result;
            }
            //Box.Text = R.Luutrutoanhang.ToString();
            R.Bieuthuc.Clear();
            R.ST = null;
            R.Trungto = null;
            R.Luutrutoanhang.Clear();
            R.Hauto.Clear();
            R.Giatri.Clear();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = plusButton.Text;
            Box.Text = Box.Text + plusButton.Text;
            loidau++;
            if (loidau == 2)
            {
                MessageBox.Show("Lỗi phép tính", "Math Error!");
                KetQuaBieuThuc.Text = "error";
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = minusButton.Text;
            Box.Text = Box.Text + minusButton.Text;
            loidau++;
            if (loidau == 2)
            {
                MessageBox.Show("Lỗi phép tính", "Math Error!");
                KetQuaBieuThuc.Text = "error";
            }
        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = multiButton.Text;
            Box.Text = Box.Text + multiButton.Text;
            loidau++;
            if (loidau == 2)
            {
                MessageBox.Show("Lỗi phép tính", "Math Error!");
                KetQuaBieuThuc.Text = "error";
            }
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = divideButton.Text;
            Box.Text = Box.Text + divideButton.Text;
            loidau++;
            if (loidau == 2)
            {
                MessageBox.Show("Lỗi phép tính", "Math Error!");
                KetQuaBieuThuc.Text = "error";
            }
        }

        private void moNgoac_Click(object sender, EventArgs e)
        {
            loidau = 0;
            kiemtra++;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = moNgoac.Text;
            Box.Text = Box.Text + moNgoac.Text;
        }

        private void dongNgoac_Click(object sender, EventArgs e)
        {
            loidau = 0;
            kiemtra--;
            BoxInputOfStack.Text = null;
            BoxInputOfStack.Text = dongNgoac.Text;
            Box.Text = Box.Text + dongNgoac.Text;
        }

        private void xoa1so_Click(object sender, EventArgs e)
        {
            
        }

        private void xoaHet_Click(object sender, EventArgs e)
        {
            loidau = 0;
            KetQuaBieuThuc.Text = null;
            BoxInputOfStack.Text = null;
            Box.Text = null;
            Bieuthuc_hauto.Text = null;
            textBox1.Text = null;
            R.Bieuthuc.Clear();
            R.ST = null;
            R.Trungto = null;
            R.Luutrutoanhang.Clear();
            R.Hauto.Clear();
            R.Giatri.Clear();
        }

        private void Box_TextChanged(object sender, EventArgs e)// đang xử lý
        {

            
        }

        private void BoxInputOfStack_TextChanged(object sender, EventArgs e)
        {
            /*if (BoxInputOfStack.Text == "+" || BoxInputOfStack.Text == "-" || BoxInputOfStack.Text == "*" || BoxInputOfStack.Text == "/")
            {
                loidau++;
                if (loidau == 2)
                {
                    MessageBox.Show("Lỗi phép tính", "Math Error!");
                    KetQuaBieuThuc.Text = "error";
                }
            }
            else
                loidau = 0;*/
            R.Trungto = BoxInputOfStack.Text;
            R.savegiatribieuthuc(R.Trungto);
            textBox1.Text = textBox1.Text + R.Trungto;
            //K.KT = BoxInputOfStack.Text;
            //Bieuthuc_hauto.Text = R.Bieuthuc.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void KetQuaBieuThuc_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
