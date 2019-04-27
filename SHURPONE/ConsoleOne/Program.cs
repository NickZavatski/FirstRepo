using SHURPONE;
using System;

namespace ConsoleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter consoleWriter = new ConsoleWriter(10); //прикол чтобы набрать классы(не используется)

           // consoleWriter.MethodOne();

            int calculated = consoleWriter.Calculate(3, 7);

            consoleWriter.WriteLine(calculated);

            int denied = StaricCLass.Deny(2, 5);//используется в классах-помошнтках

            consoleWriter.WriteLine(denied);

            IService service = new Service();//знать как Отче Наш.

            int multipliyed = service.Multiply(6, 7);

            consoleWriter.WriteLine(multipliyed);

            Console.ReadKey();
        }
    }
}
