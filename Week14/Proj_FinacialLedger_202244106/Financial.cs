using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_FinacialLedger_202244106
{
    abstract class Financial
    {
        protected Dictionary<DateTime, Info> _incomes;
        protected Dictionary<DateTime, Info> _expenditures;

        public int TotalIncome { get; }
        public int TotalExpenditure { get; }

        public virtual bool RegIncome(DateTime indate, string info, int income) 
        {
            Info inf = new Info(info, income);
            if (income >= 0)
            {
                _incomes[indate] = inf;
                
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool RegExpenditure(DateTime expenddate, string info, int expenditure) 
        {
            Info inf = new Info(info, expenditure);
            if (expenditure >= 0)
            {
                _expenditures[expenddate] = inf;

                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool RegIncome(string info, int income)
        {
            Info inf = new Info(info, income);
            if (income >= 0)
            {
                _incomes[DateTime.Now] = inf;

                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool RegExpenditure(string info, int expenditure)
        {
            Info inf = new Info(info, expenditure);
            if (expenditure >= 0)
            {
                _expenditures[DateTime.Now] = inf;
                return true;
            }
            else
            {
                return false;
            }
        }
          

        


    }
}
