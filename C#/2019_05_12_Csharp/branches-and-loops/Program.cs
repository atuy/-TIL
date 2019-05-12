using System;

namespace branches_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
                Console.WriteLine();
            }

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
             * if는 bool의 값을 확인하고 참인 경우 if 뒤의 문장을 실행합니다
             * 그렇지 않으면 건너뜁니다
             * else키워드 뒤의 문은 테스트 하는 조건이 거짓을 경우 실행된다
             * 들여쓰기가 중요하지; 않기 때문에 {}을 사용하여 
             * 두 개 이상의 문장을이 블록의 일부가 되는 시기를 나타내야 한다
             * 
             * == 기호는 같음을 테스트 한다 =과 ==가 구분 된다
             * &&는 and를 나타낸다 참 분기에서 문장을 실행 하려면 두 조건이 모두 참이여야 한다
             * || 를 사용하여 or를 나타 낼 수 있다
             * 
             */

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
            Console.WriteLine();
            /*
             * while문은 조건을 확인하고 뒤의 문장을 실행 한다 조건이 거짓이 될 떄까지 조건확인 및 문장 실행을 반복한다
             * ++ 는 증가 연산자 +1을 더하고 값을 저장한다
             */

            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
            Console.WriteLine();
            /*
             *애-while 문은 while 뒤에 코드를 먼저 실행 한 후에 조건을 확인합니다  
             */

            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
            Console.WriteLine();
            /*
             * for 문에는 작동 방식을 제어하는 세부분이 있다
             * 첫번째 부분은 for 이니셜라이저이다 counter이 루프 변수이고 첫 값을 0으로 설정한다
             * 중간 부분은 for 조건이다 counter < 10은 for 루프가 카운터 값이 10보다 작으면 계속 실행됨을 선언합니다
             * 마지막 부분은 for 반복기이다 counter++은 for문 다음의 블록을 실행 한 후 루프 변수를 수정하는 방법을 지정한다
             */

            int sum = 0;
            for(int i=1;i<=20;i++)
            {
                if(i%3==0)
                {
                    Console.Write($"{i}\t");
                    sum += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
