using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lambaExpressions.Program;

namespace lambaExpressions
{
    internal class SomeClass
    {
        public SomeClass(MathOperation mathOperation)
        {
            int result = mathOperation(7, 2);
            Console.WriteLine(result);
        }
    }
}
