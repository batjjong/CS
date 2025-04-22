using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07Homework
{
    class Product
    {
        public string ProductCode;
        public string ProductName;
        public int ProductPrice;
        public int ProductStock;
        public DateTime ProductRegDate;
               
        public int SalePrice()
        {
            TimeSpan day = DateTime.Now - this.ProductRegDate;
            if (day.Days > 30){
                return 20;
            }
            else{
                return 0;
            }                
        }

        public int CalPrice(int count)
        {
            int saleprice = this.ProductPrice - this.ProductPrice / 100 * this.SalePrice();
            int calprice = count * saleprice;
            return calprice;
        }
        public override string ToString()
        {
            return $"[{ProductCode}] {ProductName}";
        }
    }
}
