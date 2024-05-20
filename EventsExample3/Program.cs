using static System.Console;
using ClassLibrary1;
namespace EventsExample3
{
     class Program
    {
        static void Main()
        {
            Class1 class1 = new Class1();
            class1.myEvent += (int x) =>
            {
                return x > 0;
                
            };
          
            WriteLine(class1.RaiseEvent(10));
            WriteLine(class1.RaiseEvent(20));
            WriteLine(class1.RaiseEvent(-2));
            WriteLine(class1.RaiseEvent(-4));
            ReadKey();
        }
    }
}
