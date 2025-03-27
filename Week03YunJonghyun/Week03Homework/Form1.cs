using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Homework
{
    public partial class FormMain: Form
    {
        int Num1 = 0, Num2 = 0;
        String Oper;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (lblNumbers.Text == "0") { lblNumbers.Text = ""; }  // 0일때 0을 없애고 숫자 입력
            Button button = (Button)sender;
            lblNumbers.Text += button.Text;
        }

        private void btnOper_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Oper = button.Text;
            Num1 = int.Parse(lblNumbers.Text);
            lblNumbers.Text = "";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int result = 0;
            Num2 = int.Parse(lblNumbers.Text);
            if (Num2 == 0)
            {//0으로 못 나누게 함
                MessageBox.Show("0으로 나눌 수 없습니다");
                return;
            }

            switch (Oper){
                case "*":
                    result = Num1 * Num2;
                    break;
                case "/":
                    result = Num1 / Num2;
                    break;
                case "+":
                    result = Num1 + Num2;
                    break;
                case "-":
                    result = Num1 - Num2;
                    break;
                default:
                    return;
            }
            lblExpression.Text = Num1 + " " + Oper + " " + Num2 + " = " + result;
        }
    }
}
