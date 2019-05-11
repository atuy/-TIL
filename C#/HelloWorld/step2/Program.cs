using System;

namespace step2
{
    class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill";                                                                     //스트링 변수 선언
            Console.WriteLine(aFriend);                                                                  //출력

            aFriend = "Maria";                                                                           //변수 내용 변경
            Console.WriteLine(aFriend);                                                         

            Console.WriteLine("Hello " + aFriend);                                                       //+를 이용해 변수 문자열에서 문자열을 빌드 함

            Console.WriteLine($"Hello {aFriend}");                                                       // 문자열 보간을 이용해 $을 추가해 중괄호 사이 문자열 안에 변수를 포함해 출력

            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");                       // 문자열 보간은 많은 변수를 사용 해 할 수 있다

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");              // 문자열에 대양한 속성을 사용 할 수 있다
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");            //
            Console.WriteLine();

            string greeting = "      Hello World!       ";                                               // 앞 뒤 공백이 있는 문자열 생성
            Console.WriteLine($"[{greeting}]");                                                          //출력
            Console.WriteLine();

            string trimmedGreeting = greeting.TrimStart();                                               // TrimStart 메서드를 이용해 문자열의 앞 부분 공백을 삭제
            Console.WriteLine($"[{trimmedGreeting}]");
            Console.WriteLine(greeting);
            Console.WriteLine();

            trimmedGreeting = greeting.TrimEnd();                                                        //TrimEnd 메서드를 이용해 뒤부분의 공백 제거
            Console.WriteLine($"[{trimmedGreeting}]");
            Console.WriteLine(greeting);
            Console.WriteLine();

            trimmedGreeting = greeting.Trim();                                                           //Trim 메서드를 이용해 앞 뒤 공백제거 
            Console.WriteLine($"[{trimmedGreeting}]");
            Console.WriteLine(greeting);                                                                 
            Console.WriteLine();

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            Console.WriteLine();
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);
            Console.WriteLine();

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine();
            Console.WriteLine(sayHello.ToLower());
            Console.WriteLine();

            /*
             * 문자열을 조작하는 메서드는 수정하기보다는 새 문자열 객체를 반환합니다
             * 즉 문자열 속성 메서드는 새 문자열을 반환 하지만 원래 메세지는 변경하지 않는다
             */

            string songLyrics = "You say goodbye, and I say hello";                             
            Console.WriteLine(songLyrics.Contains("goodbye"));                                      //contains 메서드는 검색한 문자열을 찾았는지 bool 형식으로 반환한다
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine();

            Console.WriteLine("you starts songLyrics "+songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));;
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));


        }
    }
}
