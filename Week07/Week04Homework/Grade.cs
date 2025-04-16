using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Grade
    {   //스태틱필드
        //public static int MAX_GRADE_COUNT = 9;  값을 바꿀 수 있음
        //private static int MAX_GRADE_COUNT = 9; 값을 알려주지 못함
        
        //const = const + static
        private const int MAX_GRADE_COUNT = 9;

        //인스턴스필드
        public string StudentNumber;
#if false
        public List<double> Scores = new List<double>();
#else
        private List<double> _scores = new List<double>();

        public int Count()
        {
            return _scores.Count;
        }
        public double Get(int i)
        {
            return _scores[i];
        }

        public bool Add(double score)//최대 과목 수 
        {
            //static은 instance 의 것이 아님
            //class의 것이 아님
            //if (_scores.Count >= this.MAX_GRADE_COUNT)
            if (_scores.Count >= Grade.MAX_GRADE_COUNT){//자기구역이라 클레스 이름을 적지 않아도 됨            
                return false;
            }
            _scores.Add(score);
            return true;
        }

#endif

        //private 제어 가능 
        //public 제어 불가능
        
        //instace method 인스턴스 메소드
        //계속 만드는 값들은 인스턴스 필드가 아닌 인스턴스 메소드로 만들어야함
        public double Average() 
        {
#if false
            
            double sum = 0.0;
            foreach(var score in this.Scores){
                sum += score;
            }
            return sum / Scores.Count;
#else
            if (this._scores.Count == 0)
            {
                return -1.0;
            }
            return _scores.Average();
            return _scores.Sum() / _scores.Count;
#endif

        }
#if true
        public void Clear()
        {
            _scores.Clear();
        }
#endif
    }
}
