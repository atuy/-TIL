using System;
using System.Collections.Generic;

namespace list_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "chan", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            /*
             *문자열 목록을 만들고 해당 목록에 3개의 이름을 추가한다
             * ToUpper메서드를 통해 도무 대문자로 출력한다
             */
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            /*
             * 이름을 추가하거나 제거 할 수 있습니다
             */
            Console.WriteLine();
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            /*
             * 인덱스 별로 참조해서 출력할 수 있다
             */
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The list has {names.Count} people in it");
            /*
             * .count 메서드를 이용해 리스트의 길이를 확인할 수 있다
             */
            Console.WriteLine();
            Console.WriteLine();
            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            /*
             * IndexOf 메서드는 항목을 검색 하고 항목의 인덱스를 반환합니다
             * 항목이 목록에 있는지 알 수 없으므로 IndexOf에서 반환된 인덱스를 항상 확인해야 한다
             * 
             */
            Console.WriteLine();
            Console.WriteLine();
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            /*
             * 목록의 정렬은 sort메서드로 할 수 있다
             * 이는 사전순으로 목록을 정렬한다
             */

            Console.WriteLine();
            Console.WriteLine();
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
