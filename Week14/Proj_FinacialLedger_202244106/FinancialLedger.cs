using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202244106
{
    class FinancialLedger : Financial
    {
        private int _year;
        private int _targetAmount;

        public int Year { get; }
        public int TargetAmount { get; }
        public bool IsBlack { get; }

        public FinancialLedger(int year) 
        {
            if (TotalIncome > TotalExpenditure)
            {
                year = Year;

            }
        }
        public FinancialLedger(int year, int targetamount)
        {
            if (TotalIncome > TotalExpenditure) { 
                year = Year;
                targetamount = TargetAmount;

            }            
        }

        public override bool RegIncome(DateTime indate, string info, int income)
        {
            if (Year.ToString() == indate.ToString("yyyy")) 
            {
                return base.RegIncome(indate, info, income);
            }
            else
            {
                return false;
            }
        }

        public override bool RegExpenditure(DateTime expenddate, string info, int income)
        {
            if (Year.ToString() == expenddate.ToString("yyyy"))
            {
                return base.RegIncome(expenddate, info, income);
            }
            else
            {
                return false;
            }
        }

        public override bool RegIncome(string info, int income) 
        {
            if (Year.ToString() == DateTime.Now.ToString("yyyy"))
            {
                return base.RegIncome(DateTime.Now, info, income);
            }
            else
            {
                return false;
            }
        }

        public override bool RegExpenditure(string info, int income)
        {
            if (Year.ToString() == DateTime.Now.ToString("yyyy"))
            {
                return base.RegIncome(DateTime.Now, info, income);
            }
            else
            {
                return false;
            }
        }
    }
}
