using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHURPONE
{
    public class Service : IService
    {
        public int Multiply(int one, int two)
        {
            return one * two;
        }
    }
}
