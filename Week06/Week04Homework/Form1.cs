using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04Homework
{
    public partial class FormManager: Form
    {   //인스턴스 필드(변수), 멤버변수
        Department[] departments;
        List<Professor> professors;
        Dictionary<string,Student> students;

        List<Grade> testGrades;
        TextBox[] tbxTestScores;
        
        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣어준다
                
        public FormManager()
        {
            InitializeComponent();
            departments = new Department[100];  //배열
            professors = new List<Professor>(); //리스트
            students = new Dictionary<string, Student>();//딕셔너리

            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[]{
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3,
                tbxTestScore4,
                tbxTestScore5,
                tbxTestScore6,
                tbxTestScore7,
                tbxTestScore8,
                tbxTestScore9
            };
            //학년, 분반, 재적 상태는 디자인의 아이템에서 추가했습니다  
        }
        
        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            int index = -1;
            if(tbxDepartmentCode.Text == ""){
                MessageBox.Show("학과코드를 입력해주세요.");
                tbxDepartmentCode.Focus();
                return;
            }
            if(tbxDepartmentName.Text == ""){
                MessageBox.Show("학과이름를 입력해주세요.");
                tbxDepartmentName.Focus();
                return;
            }
            for(int i =0; i<departments.Length; i++){
                if (departments[i] == null){
                    if (index < 0){
                        index = 0;
                    }
                    index = i;
                    //break;
                }
                else{
                    if (departments[i].Code == tbxDepartmentCode.Text){
                        MessageBox.Show("동일한 코드는 사용이 불가합니다.");
                        tbxDepartmentCode.Focus();
                        return;
                    }
                }
            }

            if (index < 0){
                MessageBox.Show("학과를 받을 수 없습니다.");//메세지 띄우기 (학과를 받을수 없습니다)
                return;
            }

            //학과코드, 학과이름이 비어있으면 안됨

            Department dept = new Department();
            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);


            //삭제 예정
            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
            //삭제 예정
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0){
                MessageBox.Show("삭제할 학과를 선택해주세요.");
                return;
            }

            //is연산자, 타입확인용으로 사용
            if(lbxDepartment.SelectedItem is Department){
                var target = (Department)lbxDepartment.SelectedItem;
                for(int i = 0; i<departments.Length; i++){
                    if (departments[i] != null && departments[i] == target){// 배열에서 삭제
                        departments[i] = null;
                        break;
                    }
                }
            }
            
            lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);
            lbxDepartment.SelectedIndex = -1;//선택이 안된 상태로 만듦
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex){
                case 0:
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments){
                        if (department != null){
                            cmbProfessorDepartment.Items.Add(department);
                        }
                        cmbProfessorDepartment.SelectedIndex = -1;
                        lbxProfessor.Items.Clear();
                    }
                    break;
                case 2:
                    cmbDepartment.Items.Clear();
                    cmbAdvisor.Items.Clear();
                    foreach (var department in departments){
                        if (department != null){
                            cmbDepartment.Items.Add(department);
                        }
                        cmbDepartment.SelectedIndex = -1;
                        cmbAdvisor.SelectedIndex = -1;
                    }
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index값 검사해서 진행여부 검사??(162~165줄)
            //값을 선택하지 않으면 바꾸지 않은 처리가 됨..?
            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("조회할 학과를 선택해주세요.");
                return;
            }

            lbxProfessor.Items.Clear();
            //as 형변환 연산자
            //형변환이 정상적이지 않으면 null 반환
            var department = cmbProfessorDepartment.SelectedItem as Department;
                        
            if (department != null){
                foreach(var professor in professors){
                    //null 값 체크하기(습관),
                    if (professor != null && professor.DepartmentCode == department.Code){
                        lbxProfessor.Items.Add(professor);
                    }
                }
            }
        }

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            int index = -1; 
            
            //if (cmbProfessorDepartment.SelectedIndex < 0){
            //    MessageBox.Show("조회할 학과를 선택해주세요.");
            //    return;
            //}

            if (tbxProfessorNumber.Text == "")
            {
                MessageBox.Show("교수번호을 입력해주세요.");
                return;
            }
            if (tbxProfessorName.Text == ""){
                MessageBox.Show("교수이름을 입력해주세요.");
                return;
            }            

            for (int i = 0; i < professors.Count; i++){
                if (professors[i] == null){
                    if (index < 0){
                        index = 0;
                    }
                    index = i;
                    //break;
                }
                else{
                    if (professors[i].Number == tbxProfessorNumber.Text){
                        MessageBox.Show("동일한 코드는 사용이 불가합니다.");
                        tbxProfessorNumber.Focus();
                        return;
                    }
                }
            }

            Professor Prof= new Professor();
            var selectedDept = cmbProfessorDepartment.SelectedItem as Department;

            Prof.Number = tbxProfessorNumber.Text;
            Prof.Name = tbxProfessorName.Text;
            Prof.DepartmentCode = selectedDept.Code;
            
            professors.Add(Prof);

            lbxProfessor.Items.Add(Prof);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0){
                MessageBox.Show("삭제할 교수를 선택해주세요.");
                return;
            }
            
            //is연산자, 타입확인용으로 사용
            if (lbxProfessor.SelectedItem is Professor){
                var target = (Professor)lbxProfessor.SelectedItem;
                for (int i = 0; i < professors.Count; i++){
                    if (professors[i] != null && professors[i] == target){// 배열에서 삭제
                        professors[i] = null;
                        break;
                    }
                }
            }

            lbxProfessor.Items.Remove(lbxProfessor.SelectedItem);
            lbxProfessor.SelectedIndex = -1;//선택이 안된 상태로 만듦
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();
            var department = cmbDepartment.SelectedItem as Department;            

            if (department != null){
                foreach (var professor in professors){
                    //null 값 체크하기(습관)
                    if(professor != null && professor.DepartmentCode == department.Code){
                        cmbAdvisor.Items.Add(professor);
                    }
                }
                cmbAdvisor.SelectedIndex = -1;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tbxNumber.Text = "20";
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            tbxName.Text = "";
            tbxContact.Text = "";
            tbxAddress.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.Items.Clear();
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
        }
        Student selectedStudent = null;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(selectedStudent == null){
                RegiserStudent();//call
            }
            else{
                UpdataStudent();//call
            }
        }

        private void RegiserStudent()//define
        {
            //throw new NotImplementedException();
            var number = tbxNumber.Text.Trim();//Trim()공백 제거

            //실제 많이 사용하는 방법
            if (students.ContainsKey(number)){//bool타입을 가짐
                tbxNumber.Focus();
                return;
            }
            Student student = new Student();
            student.Number = number;
            student.Name = tbxName.Text.Trim();

            int birthYear, birthMonth; //, birthDay;
            if(int.TryParse(tbxBirthYear.Text, out birthYear)){
                
            }
            else{
                return;
            }
            
            if (int.TryParse(tbxBirthMonth.Text, out birthMonth)){

            }
            else{
                return;
            }
            
            if (int.TryParse(tbxBirthDay.Text, out int birthDay)){//

            }
            else{
                return;
            }

            //현재시간 : DateTime.Now;
            student.BirthTnfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                //cmbDepartment.Focus();
                //return;
                student.DepartmentCode = null;
            }
            else
            {
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code; //object에서 department로 복원
            }
            students[number] = student;    //딕셔너리에 데이터 추가방법1
            //students.Add(number, student); 딕셔너리에 데이터 추가방법2(비추)
            lbxDictionary.Items.Add(student);
        }

        private void UpdataStudent()//define
        {
            throw new NotImplementedException();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudent = (lbxDictionary.SelectedItem as Student);
            btnNew_Click(sender, EventArgs.Empty);//비추
            
            if (selectedStudent != null)
            {
                DisplaySelectedStudent(selectedStudent);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            tbxAddress.ReadOnly = true;
            tbxNumber.Text = selectedStudent.Number;
            tbxBirthYear.Text = selectedStudent.BirthTnfo.Year.ToString();
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);
        }

        private Student SearchStudentByNumber(string number)
        {
            if (students.ContainsKey(number)){
                return students[number];
            }
            else{ 
                return null;
            }
        }
    }
}
