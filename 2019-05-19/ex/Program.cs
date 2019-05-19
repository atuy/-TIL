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
            Console.WriteLine(var1 + var2 + var3);
            var inputint = Console.ReadLine();
            Console.WriteLine(var1.GetType());
            Console.WriteLine(var2.GetType());
            Console.WriteLine(var3.GetType());
            Console.WriteLine(inputint);
            Console.WriteLine(inputint.GetType());
            //var로 입력한 값은 string 으로 값이 저장된다.
            Console.WriteLine(var4);

            dynamic dyn = 1;
            object obj = 1;

            // Rest the mouse pointer over dyn and obj to see their
            // types at compile time.
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(obj.GetType());
            dyn = "string";
            obj = "string";
            Console.WriteLine(dyn.GetType());
            Console.WriteLine(obj.GetType());
        }
    }
}
