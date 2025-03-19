using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class FormWeek3: Form
    {
        public FormWeek3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            //배열의 가장큰 특징: 고정길이
            //배열 생성시 사용할 길이(length)를 정해놓고 시작해야함
            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            //int[] arrIntData = new int[5];
            //배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 한다
            //배열의 길이는 생성 변하지 않기 때문에
            //다른 배열의 길이로 사용해도 괜찮다
            //배열 요소의 값은
            //struct는 struct의 기본값(int는 0),(float는 0.0),(bool는 false)
            //class는 null이 기본값
            int[] arrIntData = new int[arrTbxData.Length];

            for(int i=0;i<arrTbxData.Length; i++){
                if (arrTbxData[i].Text != null && arrTbxData[i].Text != ""){
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else{
                    //arrIntData[i] = 0; ->과 동일함 ...?
                }
            }
            int result = 0;
            if (rbtAdd.Checked){
                for(int i=0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked){
                result -= arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] == 0){
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안됨");
                        return;
                    }
                    result /= arrIntData[i];
                }
            }
            else{
                MessageBox.Show("연산을 선택하세요");
                return; //메소드를 즉시 종료 후 호출한 곳으로 이동
            }
            lblResult.Text = result.ToString();
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            //배열의 가장큰 특징: 고정길이
            //배열 생성시 사용할 길이(length)를 정해놓고 시작해야함
            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            //int[] arrIntData = new int[5];
            //배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 한다
            //배열의 길이는 생성 변하지 않기 때문에
            //다른 배열의 길이로 사용해도 괜찮다
            //배열 요소의 값은
            //struct는 struct의 기본값(int는 0),(float는 0.0),(bool는 false)
            //class는 null이 기본값
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else
                {
                    //arrIntData[i] = 0; ->과 동일함 ...?
                }
            }
            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result -= arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안됨");
                        return;
                    }
                    result /= arrIntData[i];
                }
            }
            else
            {
                MessageBox.Show("연산을 선택하세요");
                return; //메소드를 즉시 종료 후 호출한 곳으로 이동
            }
            lblResult.Text = result.ToString();
        }
    }
}
