using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Week04Homework;

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
            for (int i = 1; i <= 4; i++){
                cmbYear.Items.Add(i);
            }
            cmbClass.Items.AddRange(new object[] { "A", "B", "C" });
            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("퇴학");

            departments[0] = new Department() { Code = "A001", Name = "컴퓨터정보" };
            departments[1] = new Department() { Code = "A002", Name = "컴퓨터시스템" };

            for (int i = 0; i < departments.Length; i++){
                if (departments[i] != null){
                    lbxDepartment.Items.Add(departments[i]);
                }
            }
            professors.Add(new Professor(){
                DepartmentCode = departments[0].Code,
                Number = "2020001",
                Name = "김인하"
            });

            professors.Add(new Professor(){
                DepartmentCode = departments[0].Code,
                Number = "2023003",
                Name = "김정석"
            });
            professors.Add(new Professor(){
                DepartmentCode = departments[1].Code,
                Number = "2023004",
                Name = "이공전"
            });

            students.Add("20240001", new Student(){
                Number = "20240001",
                Name = "김미영",
                RegStatus = "재학",
                Year = 1,
                BirthInfo = new DateTime(2004, 01, 01),
                DepartmentCode = "A001",
                AdvisorNumber = "2020001",
                Class = "B",
                Address = "인천 남구 용현동 100",
                Contact = "032-870-0000"
            });
            foreach (var student in students){
                if (student.Value != null){
                    lbxDictionary.Items.Add(student.Value);
                }
            }
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
        }//학과 삭제 버튼

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
                        ClearStudentInfo();
                    }
                    break;
                case 3:
                    ClearTestScoreInfo();
                    break;
                default:
                    break;
            }
        }
        
        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            
            if (cmbProfessorDepartment.SelectedIndex < 0){
                MessageBox.Show("조회할 학과를 선택해주세요.");
                return;
            }

            if (tbxProfessorNumber.Text == ""){
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
        }//교수 삭제 버튼

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
        }//소속학과 콤보박스 변경 시 

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearStudentInfo();
            lbxDictionary.SelectedIndex = -1;
        }//신규 버튼 클릭
        private void ClearStudentInfo()//학생탭 화면 초기화
        {
            selectedStudent = null;
            tbxNumber.Text = "20";
            tbxName.Text = string.Empty;
            tbxBirthYear.Text = "20";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
            tbxAddress.Text = string.Empty;
            tbxContact.Text = string.Empty;

            tbxNumber.ReadOnly = false;
            tbxAddress.ReadOnly = false;
            btnRegister.Text = "등록";
            
            selectedStudent = null;
        }
        
        //SelectedStudent 초기화
        Student selectedStudent = null;
        
        private void btnRegister_Click(object sender, EventArgs e)//학생탭 등록버튼
        {
            Student student = new Student();
            if (selectedStudent == null){
                RegiserStudent();//call
                ClearStudentInfo();//화면초기화
            }
            else{
                UpdateStudent();//call
                ClearStudentInfo();//화면초기화
            }
        }

        private void RegiserStudent()//학생 등록버튼
        {
            var number = tbxNumber.Text.Trim();
            if (students.ContainsKey(number))
            {//bool타입을 가짐
                MessageBox.Show("같은 학번이 있습니다.");
                tbxNumber.Focus();
                return;
            }
            SetStudent();
        }
        
        private void UpdateStudent()//학생 수정버튼
        {
            lbxDictionary.Items.Remove(lbxDictionary.SelectedItem);
            SetStudent();
            MessageBox.Show("수정완료");//모든 사항의 확인 및 수정이 끝나면 수정완료 메세지를 띄운 후 
             
        }

        private void SetStudent()//학생 정보 저장
        {
            var number = tbxNumber.Text.Trim();//Trim()공백 제거
            var name = tbxName.Text.Trim();
                        
            Student student = new Student();

            if(number.Length == 8){
                student.Number = number;
            }
            else{
                MessageBox.Show("학번을 8자리로 입력해주세요");
                tbxNumber.Focus();
                return;
            }
            if(name.Length >= 2){
                student.Name = name;
            }
            else{
                MessageBox.Show("이름을 2글자 이상 입력해주세요");
                tbxName.Focus();
                return;
            }

            if(int.TryParse(tbxBirthYear.Text, out int birthYear)){
                if (int.Parse(tbxBirthYear.Text) >= 1900 && int.Parse(tbxBirthYear.Text) <= 9000){

                }
                else{
                    MessageBox.Show("1900~9000사이의 숫자를 입력해주세요");
                    tbxBirthYear.Focus();
                    return;
                }
            }
            else{
                MessageBox.Show("정수를 입력해주세요");
                return;
            }
            if(int.TryParse(tbxBirthMonth.Text, out int birthMonth)){
                if (int.Parse(tbxBirthMonth.Text) >= 1 && int.Parse(tbxBirthMonth.Text) <= 12){

                }
                else{
                    MessageBox.Show("1~12사이의 숫자를 입력해주세요");
                    tbxBirthMonth.Focus();
                    return;
                }
            }
            else{
                MessageBox.Show("정수를 입력해주세요");
                return;
            }
            if(int.TryParse(tbxBirthDay.Text, out int birthDay)){
                if (int.Parse(tbxBirthDay.Text) >= 1 && int.Parse(tbxBirthDay.Text) <= 31){

                }
                else{
                    MessageBox.Show("1~31사이의 숫자를 입력해주세요");
                    tbxBirthDay.Focus();
                    return;
                }
            }
            else{
                MessageBox.Show("정수를 입력해주세요");
                return;
            }

            //현재시간 : DateTime.Now;
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if(cmbDepartment.SelectedIndex < 0){//소속학과 설정, 없으면 null처리
                student.DepartmentCode = null;
            }
            else{
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code; //object에서 department로 복원
            }//소속학과
            if(cmbAdvisor.SelectedIndex < 0){//지도교수 설정, 없으면 null처리
                student.AdvisorNumber = null;
            }
            else{
                student.AdvisorNumber = (cmbAdvisor.SelectedItem as Professor).Number;
            }//지도교수
            if(cmbYear.SelectedIndex < 0){//학년 설정 없으면 진행불가
                MessageBox.Show("학년을 선택해주세요");
                return;
            }
            else{
                student.Year = int.Parse(cmbYear.SelectedItem.ToString());
            }//학년
            if(cmbClass.SelectedIndex < 0){//반 설정 없으면 진행불가
                MessageBox.Show("반을 선택해주세요");
                return;
            }
            else{
                student.Class = cmbClass.SelectedItem.ToString();
            }//반
            if(cmbRegStatus.SelectedIndex < 0){//재학 설정 없으면 진행불가
                MessageBox.Show("반을 선택해주세요");
                return;
            }
            else{
                student.RegStatus = cmbRegStatus.SelectedItem.ToString();
            }//재적상태

            student.Address = tbxAddress.Text;//주소 설정
            student.Contact = tbxContact.Text;//연락처 설정

            students[number] = student;
            lbxDictionary.Items.Add(student);
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)//lblDictionary에서 선택시
        {
            var student = (lbxDictionary.SelectedItem as Student);
            if (lbxDictionary.SelectedIndex < 0){
                return;
            }
                        
            //btnNew_Click(sender, EventArgs.Empty);

            if (student != null){
                DisplaySelectedStudent(student);
            }
        }

        private void DisplaySelectedStudent(Student student)//lblDictionary에서 선택시 화면 설정
        {
            selectedStudent = student;
            tbxNumber.ReadOnly = true;//학번 읽기모드
            tbxNumber.Text = selectedStudent.Number;//학번 설정
            tbxName.Text = selectedStudent.Name;//이름 설정
            tbxBirthYear.Text = selectedStudent.BirthInfo.Year.ToString();//생년
            tbxBirthMonth.Text = selectedStudent.BirthInfo.Month.ToString();//생월
            tbxBirthDay.Text = selectedStudent.BirthInfo.Day.ToString();//생일
            
            for (int i = 0; i < cmbDepartment.Items.Count; i++){//소속학과
                if ((cmbDepartment.Items[i] as Department).Code == selectedStudent.DepartmentCode){
                    cmbDepartment.SelectedIndex = i;
                    break;
                }
            }//소속학과
            for (int i = 0; i < cmbAdvisor.Items.Count; i++){//지도교수
                if ((cmbAdvisor.Items[i] as Professor).Number == selectedStudent.AdvisorNumber){
                    cmbAdvisor.SelectedIndex = i;
                    break;
                }
            }//지도교수
            for (int i = 0; i < cmbYear.Items.Count; i++){//학년
                if (cmbYear.Items[i].ToString() == selectedStudent.Year.ToString())
                {
                    cmbYear.SelectedIndex = i;
                    break;
                }
            }//학년
            for (int i = 0; i < cmbClass.Items.Count; i++){//반
                if (cmbClass.Items[i].ToString() == selectedStudent.Class.ToString()){
                    cmbClass.SelectedIndex = i;
                    break;
                }
            }//반
            for (int i = 0; i < cmbRegStatus.Items.Count; i++){//재적상태
                if (cmbRegStatus.Items[i].ToString() == selectedStudent.RegStatus.ToString()){
                    cmbRegStatus.SelectedIndex = i;
                    break;
                }
            }//재적상태

            tbxAddress.Text = selectedStudent.Address.ToString();//주소
            tbxContact.Text = selectedStudent.Contact.ToString();//연락처

            btnRegister.Text = "수정";
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)//성적처리탭의 검색버튼 클릭
        {
            

            if (tbxTestNumber.Text == ""){
                MessageBox.Show("학번을 입력해주세요.");
                tbxTestNumber.Focus();
                return;
            }

            selectedStudent = SearchStudentByNumber(tbxTestNumber.Text);

            if (selectedStudent == null){
                MessageBox.Show("해당 학번의 학생을 찾을 수 없습니다.");
                tbxTestNumber.Focus();
                return;
            }

            
            lblTestName.Text = selectedStudent.Name;

            Grade grade = SearchGradeByNumber(selectedStudent.Number);

            if(grade != null){
                for(int i = 0; i < grade.Count() && i < tbxTestScores.Length; i++){
                    tbxTestScores[i].Text = grade.Get(i).ToString("0.0");
                }
            }
        }

        private Grade SearchGradeByNumber(string number) 
        {
            foreach(Grade grade in testGrades){
                if(grade.StudentNumber == number){
                    return grade;
                }
            }
            return null;
        }

        private void ClearTestScoreInfo()//화면정리
        {
            tbxTestNumber.Text = "";
            lblTestName.Text = "";
            tbxTestScore1.Text = "";
            tbxTestScore2.Text = "";
            tbxTestScore3.Text = "";
            tbxTestScore4.Text = "";
            tbxTestScore5.Text = "";
            tbxTestScore6.Text = "";
            tbxTestScore7.Text = "";
            tbxTestScore8.Text = "";
            tbxTestScore9.Text = "";
            lblTestAverage.Text = "";
            lblTestTotalCount.Text = "";            
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

        private void btnTestRegScore_Click(object sender, EventArgs e)
        {
            if(selectedStudent == null){
                tbxTestNumber.Focus();
                return;
            }
            //학생의 성적 입력한 항목중 중간이 비어있으면 안됨. 숫자가 안 들어갔을 때
            for(int i=1; i<tbxTestScores.Length; i++){
                if (string.IsNullOrEmpty(tbxTestScores[i-1].Text)&&false == string.IsNullOrEmpty(tbxTestScores[i - 1].Text)){ 
                    tbxTestScores[i - 1].Focus();
                }                    
            }
            var grade = SearchGradeByNumber(selectedStudent.Number);
            if(grade == null){
                grade = new Grade();
                grade.StudentNumber = selectedStudent.Number;
                //grade = new Grade(){StudentNumber = selectedStudent.Number};
            }

#if false
            grade.Scores.Clear();
#else
            grade.Clear();
#endif
            double temp;
            for(int i = 0; i<tbxTestScores.Length; i++){
                if (string.IsNullOrEmpty(tbxTestScores[i].Text)){
                    break;
                }
                if(false == double.TryParse(tbxTestScores[i].Text,out temp)){
                    tbxTestScores[i].Focus();
                    return;
                }
                //grade의 Scores를 리스트로 만들었다면?
                //grade의 Scores를 배열로 만들었다면?
                //grade의 Scores를 딕셔너리로 만들었다면?
                grade.Scores.Add(temp);
            }
            testGrades.Add(grade);
#if false
            lblTestTotalCount.Text = grade.Scores.Count.ToString();//총 과목 수 출력
#else
            lblTestTotalCount.Text = grade.Count().ToString();

#endif

#if false   //평균 출력

#else
            double average = grade.Average();
#endif
            lblTestAverage.Text = average.ToString();
        }
    }
}
