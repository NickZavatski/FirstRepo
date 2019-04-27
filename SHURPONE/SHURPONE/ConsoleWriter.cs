using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHURPONE
{
    public class ConsoleWriter
    {
        private int _mult;

        public ConsoleWriter(int mult)
        {
            _mult = mult;
        }

        public void MethodOne()
        {
            Console.WriteLine("VLIDAPIDR");

            Console.ReadKey();
        } 

        public void WriteLine(object ob)
        {
            Console.WriteLine(ob);


        }

        public int Calculate(int one, int two)
        {
            return (one + two) * _mult;
        }
    }
}
