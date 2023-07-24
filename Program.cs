using System.ComponentModel;

namespace lambaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(abc));
            //Func<int, int> square = (x) => x * x;

            //Func<int, int> square = (x) =>
            //{
            //    Console.WriteLine(x);
            //    return x * x;
            //};

            MathOperation mathOperation = Add;

            int result = mathOperation(5, 3);

            mathOperation = multiply;

            mathOperation(10, 10);

            Console.WriteLine(result);

            SomeClass someClass = new SomeClass(multiply);

        }

        public delegate int MathOperation(int x, int y);

        static int Add (int x, int y) => x + y;
        static int multiply(int x, int y) => x * y;
        static void abc()
        {

        }
    }
}