using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    class  Program
    {
        public static int count = 0;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(multiplynumbers(2, 10));
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            //------分治法所花费计时周期<<普通方法
            sw.Reset();
            sw.Start();
            Console.WriteLine(discerptionmultipnumbers(1.323, 1000000));
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            //---fibonacci
            sw.Reset();
            sw.Start();
            Console.WriteLine(discerptionmultipnumbers2(1.323, 1000000));
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
            Console.WriteLine(count);
        }

        /// <summary>
        /// 整数幂 幂运算（普通方式） T(N)=O(N)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static double multiplynumbers(double x, int n)
        {
            double temp = x;
            while (n > 1)
            {
                n--;
                x = x * temp;
            }
            return x;

            //if (n>1)
            //{
            //   return x * multiplynumbers(x, --n);
            //}
            //else
            //{
            //    return x;
            //}
        }

        /// <summary>
        /// 整数幂 幂运算 （分治法） T(n/2)=O(N)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static double discerptionmultipnumbers(double x, int n)
        {
            double temp = x;
            if (n % 2 == 0)
            {
                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    x = x * temp;
                }
                return x * x;
            }
            else
            {
                for (int i = 0; i < (n - 1) / 2 - 1; i++)
                {
                    x = x * temp;
                }
                return x * x * temp;
            }
        }
        static double discerptionmultipnumbers2(double x, int n)
        {
            
            if (n == 0)
            {
                return 1;
            }
            else if(n==1)
            {
                return x;
            }
            if (n % 2 == 0)
            {
                count++;
                return discerptionmultipnumbers2(x, n / 2) * discerptionmultipnumbers2(x, n / 2);
            }
            else
            {
                return discerptionmultipnumbers2(x, n / 2) * discerptionmultipnumbers2(x, n / 2)*x;
            }
        }

        static long Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        /// <summary>
        /// 最大连续子序列问题
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        static int Max_SubseqSum(int[] seq)
        {

            return 0;
        }
    }
}
