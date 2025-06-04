using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202244106
{
    class Info
    {
        public string Content { get; set; }
        public int Money { get; set; }

        public Info(string content, int money)
        {
            content = Content;
            money = Money;
        }

        public override string ToString()
        {
            return $"{Content},{Money}";
        }
    }
}
