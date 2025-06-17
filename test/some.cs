using System;
using System.Linq;
namespace StaticTest
{
    struct StructTest
    {
        public int Age;
        public string Name { get { return ""; } }
    }
    class BaseClass
    {
        public static int a = 10;
    }
    class DerivedClass : BaseClass
    {
        private int _year;
#if false
 //일반적인 Property
 public int Year {
 get { return _year; }
 set { _year = value; }
 }
#else
        //람다를 사용한 Property
        public int Year { get => _year; set => _year = value; }
#endif
        public static T Sum<T>(T[] a)
        where T : struct
        {
            T sum = default(T);
            for (int i = 0; i < a.Length; i++)
            {
                sum += (dynamic)a[i];
            }
            return sum;
        }
        public static int Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public static double Sum(double[] a)
        {
            double sum = 0.0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 정적필드의 상속
            BaseClass.a = 20;
            DerivedClass.a = 30;
            Console.WriteLine(BaseClass.a);
            Console.WriteLine(DerivedClass.a);
            #endregion
            #region class VS. struct
            DerivedClass c = new DerivedClass();
            DerivedClass d = c;
            c.Year = 20;
            d.Year = 10;
            Console.WriteLine($"DerivedClass:{c.Year} {d.Year}");
            StructTest s = new StructTest();
            StructTest q = s;
            s.Age = 20;
            q.Age = 10;
            Console.WriteLine($"StructTest:{s.Age} {q.Age}");
            #endregion
            #region method overload VS. generic
            //method overload
            Console.WriteLine(DerivedClass.Sum(new double[] { 1.1, 2.2, 3.3 }));
            Console.WriteLine(DerivedClass.Sum(new int[] { 1, 2, 3 }));
            //generic
            Console.WriteLine(DerivedClass.Sum<double>(new double[] { 1.1, 2.2, 3.3 }));
            Console.WriteLine(DerivedClass.Sum<int>(new int[] { 1, 2, 3 }));
            #endregion
            #region 람다 예제
            var t = args.FirstOrDefault(m => m == "1");
            //(람다) m => m == "1"
            //(일반메소드) bool Test(string m)
            // {
            // return m == "1";
            // }
            #endregion
        }
    }
}
