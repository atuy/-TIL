using System;

namespace numbers_in_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine($"a={a}\t b={b}\t c={c}");
            Console.WriteLine($"a+b*c={d}");
            Console.WriteLine();

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"a={a}\t b={b}\t c={c}");
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            Console.WriteLine();

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
            Console.WriteLine();
            /*
             * c#의 정수 형식은 최소 한도와 최대 한도가 있다 
             */
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
            Console.WriteLine();

            /*
             * double 방식은 배정밀도 부동 소수점을 나타낸다
             * 부동 소수점은 아주 크거나 작은 정수가 아닌 수를 나타낼 때 유용합니다.
             * 배정밀도란 이러한 숫자가 단정밀도보다 큰 전체 자리수를 사용하여 저장됨을 의미 합니다
             * 컴퓨터에서는 배정밀도를 더 많이 사용함
             */

            double d_a = 5;
            double d_b = 4;
            double d_c = 2;
            double d_d = (d_a + d_b) / d_c;
            Console.WriteLine($"a={d_a}\tb={d_b}\tc={d_c}\n a + b / c = {d_d}");
            Console.WriteLine();

            d_a = 19;
            d_b = 23;
            d_c = 8;
            d_d = (d_a + d_b) / d_c;
            Console.WriteLine($"a={d_a}\tb={d_b}\tc={d_c}\n a + b / c = {d_d}");
            Console.WriteLine();


            double d_max = double.MaxValue;
            double d_min = double.MinValue;
            Console.WriteLine($"The range of double is {d_min} to {d_max}\n");
            /*
             * 최대 최소값은 과학적 표기법으로 출력된다
             * E 의 왼쪽에 있는 숫자는 유효 숫자이고 오른쪽의 숫자는 지수이다
             */

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            /*
             * 0.3333333과 1/3은 정확하게 동일하지 않다
             */

            decimal de_min = decimal.MinValue;
            decimal de_max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {de_min} to {de_max}");
            Console.WriteLine();

            /*
             *decimal 형식은 범위가 적지만 double 보다 전체 자리수가 더 크다
             */

            d_a = 1.0;
            d_b = 3.0;
            Console.WriteLine(d_a / d_b);
            Console.WriteLine();

            decimal de_c = 1.0M;
            decimal de_d = 3.0M;
            Console.WriteLine(de_c / de_d);
            Console.WriteLine();
            /*
             * 숫자의 M 접미사는 상수가 decimal 형식을 사용해야합을 나타낸다
             */

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

        }
    }
}
