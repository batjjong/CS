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
{   //class 구성요소 : 값(변수) + 기능(메소드)

    public partial class FormWeek3: Form
    {   
        //인스턴스 변수
        //멤버 변수
        //C#에서는 필드라고 부름
        TextBox[] arrTbxData = new TextBox[5];
        //변수선언, 초기화까진 가능

        RadioButton[] radioButtons;
        List<CheckBox> checkBoxes;

        //생성자(public)
        //(1)이름은 Class와 동일,
        //(2)반환타입이 표시하면 안됨
        //생성시 무조건 1번만 호출됨
        public FormWeek3()
        {
            InitializeComponent();
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            radioButtons = new RadioButton[]{
                rbtAdd,
                rbtSub,
                rbtMul,
                rbtDiv
            }
            ;
            checkBoxes = new List<CheckBox>{
                chkAdd,
                chkSub,
                chkMul,
                chkDiv
            };
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnProcess1_Click(object sender, EventArgs e)
        {
            //배열의 가장큰 특징: 고정길이
            //배열 생성시 사용할 길이(length)를 정해놓고 시작해야함
            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

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
                for (int i = 1; i < arrIntData.Length; i++){
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++){
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
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //int[] arrIntData = new int[5];
            //배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 한다
            //배열의 길이는 생성 변하지 않기 때문에
            //다른 배열의 길이로 사용해도 괜찮다
            //배열 요소의 값은
            //struct는 struct의 기본값(int는 0),(float는 0.0),(bool는 false)
            //class는 null이 기본값
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++){
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)){
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else{
                    //arrIntData[i] = 0; ->과 동일함 ...?
                }
            }
            int result = 0;
            if (rbtAdd.Checked){
                for (int i = 0; i < arrIntData.Length; i++){
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked){
                result -= arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++){
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++){
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++){
                    if (arrIntData[i] == 0){
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
        private void btnProcess3_Click(object sender, EventArgs e)
        {
            //Array vs. List
            //고정길이(Length) = 가변길이(Count)
            //Length = Count
            //공통점:요소접근방법[index]
            //string a= "11";
            //int b = a.Length;
            //a+="b";      ->"11b"
            //b = a.Length -> 3    //문자열은 고정길이

            TextBox[] arrTbxData = new TextBox[5];

            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //int[] arrIntData = new int[arrTbxData.Length];
            //Generic(일반화) 지원자료형 -> <>를 밭여줘야함

            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++){
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)){
                    //Add()가 있다면 Insert() Remove()
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                }
                else
                {
                    //arrIntData[i] = 0; ->과 동일함 ...?
                }
            }
            int result = 0;
            if (rbtAdd.Checked){
                for (int i = 0; i < arrIntData.Count; i++){
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result -= arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++){
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++){
                    if (arrIntData[i] == 0){
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
        private void btnProcess4_Click(object sender, EventArgs e){
            //Array vs. List (wnddy)
            //고정길이(Length) = 가변길이(Count)
            //Length = Count
            //공통점:요소접근방법[index]
            //string a= "11";
            //int b = a.Length;
            //a+="b";      ->"11b"
            //b = a.Length -> 3    //문자열은 고정길이

            TextBox[] arrTbxData = new TextBox[] {
                tbxData1,
                tbxData2,
                tbxData3,
                tbxData4,
                tbxData5,
            };

            //int[] arrIntData = new int[arrTbxData.Length];
            //Generic(일반화) 지원자료형 -> <>를 밭여줘야함

            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++){
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)){
                    //Add()가 있다면 Insert() Remove()
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                }
                else{
                    //arrIntData[i] = 0; ->과 동일함 ...?
                }
            }
            int result = 0;
            string total_result = "";
            if(!chkAdd.Checked && 
               !chkSub.Checked &&
               !chkMul.Checked &&
               !chkDiv.Checked){
                MessageBox.Show("연산을 선택하세요");
                return; //메소드를 즉시 종료 후 호출한 곳으로 이동
            }
            lblResult.Text = total_result.ToString();
            if (chkAdd.Checked){
                for (int i = 0; i < arrIntData.Count; i++){
                    result += arrIntData[i];
                }
                total_result += $"더하기:{result}";
                total_result += Environment.NewLine;

            }
            if (chkSub.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++){
                    result -= arrIntData[i];
                }
                total_result += $"빼기:{result}";
                total_result += Environment.NewLine;
            }
            if (chkMul.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++){
                    result *= arrIntData[i];
                }
                total_result += $"곱하기:{result}";
                total_result += Environment.NewLine;
            }
            if (chkDiv.Checked){
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++){
                    if (arrIntData[i] == 0){
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안됨");
                        return;
                    }
                    result /= arrIntData[i];
                }
                total_result += $"나누기:{result}";
                total_result += Environment.NewLine;
            }
            
        }
        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            //객체지향 + GUI -> event지향
            
            var isEng = chkOption.Checked;
            string word;
            for(int i = 0; i<radioButtons.Length; i++){
                switch (i){
                    case 0: 
                        word = isEng ? "Add" : "더하기";
                        break;
                    case 1:
                        word = isEng ? "Sub" : "빼기";
                        break;
                    case 2:
                        word = isEng ? "Mul" : "곱하기";
                        break;
                    case 3:
                        word = isEng ? "Div" : "나누기";
                        break;
                    default:continue;
                }
                radioButtons[i].Text = word;
                checkBoxes[i].Text = word;
            }
        }
        private void btnProcess6_Click(object sender, EventArgs e){
            //ComBox 미선택시 SelectedIndex == -1
            if (cmbBeverage.SelectedIndex < 0){
                MessageBox.Show("음료를 선택하세요");
                return;
            }
                       
            int price = 0;
            switch (cmbBeverage.SelectedItem.ToString())
            {
                case "아메리카노": 
                    price = 2500;
                    break;
                case "카페라떼":
                    price = 3500;
                    break;
                case "플랫화이트":
                    price = 3800;
                    break;
                default:
                    return;
            }
            //가변타입
            var iceoption = chkIce.Checked ? "아이스" : "";//문자열타입
            var iceprice = chkIce.Checked ? 500 : 0;      //정수타입
                                                          //iceprice = "100";

            lblResult.Text = 
                $"{iceoption}{cmbBeverage.SelectedItem}: " +
                $"{price + iceprice}";
        }
        private void btnProcess7_Click(object sender, EventArgs e)
        {
            //ComBox 미선택시 SelectedIndex == -1
            if (cmbBeverage.SelectedIndex < 0)
            {
                MessageBox.Show("음료를 선택하세요");
                return;
            }

            int price = 0;
            switch (cmbBeverage.SelectedIndex)
            {
                case 0:
                    price = 2500;
                    break;
                case 1:
                    price = 3500;
                    break;
                case 2:
                    price = 3800;
                    break;
                default:
                    return;
            }
            //가변타입
            var iceoption = chkIce.Checked ? "아이스" : "";//문자열타입
            var iceprice = chkIce.Checked ? 500 : 0;      //정수타입
                                                          //iceprice = "100";

            lblResult.Text =
                $"{iceoption}{cmbBeverage.SelectedItem}: " +
                $"{price + iceprice}";
        }
        private void btnProcess8_Click(object sender, EventArgs e)
        {
            //ComBox 미선택시 SelectedIndex == -1
            if (cmbBeverage.SelectedIndex < 0)
            {
                MessageBox.Show("음료를 선택하세요");
                return;
            }
            //배열의 길이는 값이 변경되지 않는 것을 보장해야 한다
            //var prices = new int[]{cmbBeverage.SelectedItem.Count};
            var prices = new int[] {2500,3500,3800};
            int price = 0;
            if (cmbBeverage.SelectedIndex < prices.Length){
                price = prices[cmbBeverage.SelectedIndex];
            }
            else {
                return;
            }

            //가변타입
            var iceoption = chkIce.Checked ? "아이스" : "";//문자열타입
            var iceprice = chkIce.Checked ? 500 : 0;      //정수타입
                                                          //iceprice = "100";

            lblResult.Text =
                $"{iceoption}{cmbBeverage.SelectedItem}: " +
                $"{price + iceprice}";
        }

        
    }
}
