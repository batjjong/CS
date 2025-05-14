using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    interface IRobot
    {
        //인터페이스의 구성요소는 모두 public
        //그래서 접근제한자 사용하지 말것

        //자동구현프로퍼티가 아님
        //프로퍼티를 구현해야함
        int BatteryLevel { get; set; }
        void Charge();
    }
}
