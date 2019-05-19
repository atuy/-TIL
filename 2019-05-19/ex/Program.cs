using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            // When the type of a variable is clear from the context, use var 
            // in the declaration.
            var var1 = "This is clearly a string.";
            var var2 = 27;
            var var3 = Convert.ToInt32(Console.ReadLine());
            var var4 = var2 + var3;
            Console.WriteLine(var1+"\tvar1의 타입은 " + var1.GetType());
            Console.WriteLine();
            Console.WriteLine(var2+"\tvar2의 타입은 " + var2.GetType());
            Console.WriteLine();
            Console.WriteLine(var3+"\tvar3의 타입은 " + var3.GetType());
            Console.WriteLine();

            var inputint = Console.ReadLine();
            Console.WriteLine(inputint);
            Console.WriteLine("input의 타입은 " + inputint.GetType());
            Console.WriteLine();
            //var로 입력한 값은 string 으로 값이 저장된다.
            Console.WriteLine("var2+ var3의 연산 결과" + var4);
            Console.WriteLine();
            Console.WriteLine();




            dynamic dyn = 1;
            object obj = 1;
            dyn = dyn + 3;
            //obj = obj + 3; 오류 
            Console.WriteLine("dyn = " + dyn + "\t" + dyn.GetType());
            Console.WriteLine("obj = " + obj + "\t" + obj.GetType());
            Console.WriteLine();
            dyn = "string";
            obj = "string";
            Console.WriteLine("dyn = " + dyn + "\t" + dyn.GetType());
            Console.WriteLine("obj = " + obj + "\t" + obj.GetType());
            Console.WriteLine();
            //둘다 출력은 int32
            //string 으로 출력됨
            /*
             * dynamic 형식은 대부분의 상황에서 object 형식처럼 동작합니다.
             * 그러나 dynamic 형식의 식을 포함하는 작업은 컴파일러에서 확인되거나 형식이 검사되지 않습니다. 
             * 파일러는 작업에 대한 정보를 패키지하며, 나중에 해당 정보는 런타임에 작업을 평가하는 데 사용됩니다
             * 이 과정에서 dynamic 형식의 변수는 object 형식의 변수로 컴파일됩니다.
             * 따라서 dynamic 형식은 컴파일 시간에만 존재하고 런타임에는 존재하지 않습니다.
             */
            dynamic d;
            int i = 20;
            d = (dynamic)i;
            Console.WriteLine(d + "\t" + d.GetType());
            Console.WriteLine();
            string s = "Example string.";
            d = (dynamic)s;
            Console.WriteLine(d + "\t" + d.GetType());
            Console.WriteLine();
            DateTime dt = DateTime.Today;
            d = (dynamic)dt;
            Console.WriteLine(d + "\t" + d.GetType());
            Console.WriteLine();


           
        }
    }
}
