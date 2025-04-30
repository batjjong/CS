using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    //Object 클래스를 상속한 Department
    class Department
    {
        //인스턴스 필드
        private string _code;
        private string _name;

        //속성, property
        //getter + setter 한번에 구현
        //정의는 method와 유사
        //사용은 variable와 유사
        //TextBox의 Text도 property
        public string Code
        {
            get { return _code; }
            private set {
                if (false == string.IsNullOrEmpty(value))
                { _code = value; }
                else{
                    _code = "[ERR]" + value;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            private set {
                if (false == string.IsNullOrEmpty(value) && value.Length >= 2)
                { _name = value; }
                else{
                    _name = "[ERR]" + value;
                }
            }
        }


        //getter 외부에 값을 알려줌
        public string GetCode()
        {
            return _code;
        }

        //setter 값을 변경..?
        //무조건 public이 아님
        private void SetCode(string value)
        {
            if(false == string.IsNullOrEmpty(value))
            {
                _code = value;
            }
            
        }


        //인스턴스 메소드
        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }

        
        
        //생성자, constructor
        //반환 타입 X
        //클래스이름 동일
        
        //메소드 오버로딩
        //동일한 메소드 이름을 만들 수 있음
        //방법 : 매게변수의 갯수나 다르게 하면 됨

        //기본(default) 생성자
        //컴파일러가 만들어 줌
        //조건, 하나라도 사용자가 만든 생성자가 있으면 안 만들어 줌
        public Department()
        {
        
        }
        
        public Department(string code, string name)
        {
            Code = code;
            Name = name;
        }
    
    }
}
