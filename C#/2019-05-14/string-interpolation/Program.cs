using System;

namespace string_interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *문자열 보간 기능은 복합서식지정 기능을 기반으로 빌드되고 결과 문자열에 서식이 지정된 식 결과를 포함하는 읽기 쉽고 편리한 구문이다.
             *문자열 리터럴을 보간된 문자열로 식별하려면 $기호를 추가해 사용한다
             * 아래의 예제에서 볼 수 있듯 중괄호{}를 포함해 보간된 문자열에 식을 포함합니다.
             */
            double a = 3;
            double b = 4;
            Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
            Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");
            Console.WriteLine();
            Console.WriteLine();
            double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

            /*
             * 컴파일 시 보간된 문자열은 일반적으로 String.Format 메서드 호출로 변환된다
             */


            //보간된 식의 서식 문자열을 지정하는 법
            // 콜론 : 과 형식 문자열을 사용하여 보간된 식에 따라 형식 문자열을 지정합니다
            var date = new DateTime(1731, 11, 25);
            Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");
            Console.WriteLine();
            Console.WriteLine();


            //필드 너비와 서식이 지정된 보간된 식의 맞춤을 제어하는 방법
            //쉼표 , 및 상수 식을 포함한 보간된 식에 따라 최소 필드 너비 및 서식이 지정된 결돠의 맞춤을 지정한다

            const int NameAlignment = -14;
            const int ValueAlignment = 10;

            Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
            Console.WriteLine($"|{"Arithmetic",NameAlignment}|{0.5 * (a + b),ValueAlignment:F3}|");
            Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:F3}|");
            Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1 / a + 1 / b),ValueAlignment:F3}|");
            Console.WriteLine();
            Console.WriteLine();
            //위 예제에서 맞춤을 지정하고 파이프 문자 | 를 사용해 텍스트 필드를 구분하는 방법을 보여준다



            //보간된 문자열에서 이스케이프 시퀀스를 사용하는 방법
            /*
             * 보간된 문자열에서는 일반 문자열 리터럴을 사용할 수 있는 모든 이스케이프 시퀀스를 지원한다
             * 이스케이프 시퀀스를 문자 그대로 해석하려면 약어 리터럴 문자열을 사용합니다
             * 약어 보간된 문자열은 @ 문자 뒤에 오는 $ 문자로 시작한다
             * 중괄호를 포함하려면 결과 문자열에서 2개의 중괄호를 사용해야한다
             */

            var xs = new int[] { 1, 2, 7, 9 };
            var ys = new int[] { 7, 9, 12 };
            Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}} sets.");
            Console.WriteLine();
            var userName = "Jane";
            var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
            var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
            Console.WriteLine(stringWithEscapes);
            Console.WriteLine(verbatimInterpolated);
            Console.WriteLine(); Console.WriteLine();



            //보간된 식에서 3개로 구성된 ?: 조건부 연산자를 사용하는법
            //보간된 식에서 :은 특별한 의미가 있으므로 식에서 사용하기 위해서는 괄호로 묶어야 한다
            var rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
            }
            Console.WriteLine(); Console.WriteLine();


            //문자열 보간을 사용하여 문화권별 결과 문자열을 만드는 방법
            /*
             * 기본적으로 보간된 문자열은 모든 서식 지정작업에 대해
             * CultureInfo.GetCultureInfo 속성에서 정의한 현재 문화권을 사용한다
             */
            var cultures = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("en-US"),
                System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
                System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
                System.Globalization.CultureInfo.InvariantCulture
            };

            var date_1 = DateTime.Now;
            var number = 31_415_926.536;
            FormattableString message = $"{date_1,20}{number,20:N3}";
            foreach (var culture in cultures)
            {
                var cultureSpecificMessage = message.ToString(culture);
                Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
            }
            Console.WriteLine(); Console.WriteLine();

        }
    }
}
