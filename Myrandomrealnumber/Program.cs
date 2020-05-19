using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Random r = new Random();
            a = r.Next(100);

            while (true)
            {
                Console.Write("숫자를 입력해주세요:");
                b = int.Parse(Console.ReadLine());

                if (a > b)
                    Console.WriteLine(b + "보다는 큰 숫자입니다.");
                else if (a < b)
                    Console.WriteLine(b + "보다는 작은 숫자입니다.");
                else
                {
                    Console.WriteLine("정답입니다.");
                    break;
                }
            }
        }
    }
}
