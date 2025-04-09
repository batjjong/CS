using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Grade
    {   //스태틱필드
        public static int MAX_GRADE_COUNT = 9;

        //인스턴스필드
        public string StudentNumber;
        public List<double> Scores = new List<double>();
    }
}
