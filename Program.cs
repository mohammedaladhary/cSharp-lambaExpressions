using System.ComponentModel;

namespace lambaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = new Thread(new ThreadStart(abc));
            //Func<int, int> square = (x) => x * x;

            //Func<int, int> square = (x) =>
            //{
            //    Console.WriteLine(x);
            //    return x * x;
            //};

            //MathOperation mathOperation = Add;

            //int result = mathOperation(5, 3);

            //mathOperation = multiply;

            //mathOperation(10, 10);

            //Console.WriteLine(result);

            //SomeClass someClass = new SomeClass(multiply);

            List<Person> list = new List<Person>()
            {
               new Person("salim", 22, "Male", "sohar"),
            new Person("salim", 23, "Male", "sohar"),
            new Person("salim", 25, "Male", "sohar"),
            new Person("ali", 20, "Male", "muscat"),
            new Person("shagufta", 25, "Female", "muscat"),
            new Person("Aliya", 19, "Female", "sohar"),
            new Person("Fariha", 30, "Female", "muscat"),
            new Person("Farzana", 35, "Female", "salalah"),
            new Person("Muqeet", 20, "Male", "sohar"),
            new Person("Sehar", 18, "Female", "muscat")
            };

            List<Person> persons = list
                .Where(x => x.Age <= 25)
                .OrderBy(x => x.Name)
                .ToList();


            Person? person = list.FirstOrDefault(x => x.Address == "muscat");
            //if(person != null)
            //{
            //    Console.WriteLine(person.Name);
            //}
            Console.WriteLine(person?.Name ?? "Hello"); //coalesing operator
            printPersonList(persons);

        }

        public delegate int MathOperation(int x, int y);

        static int Add (int x, int y) => x + y;
        static int multiply(int x, int y) => x * y;
        static void abc()
        {
            //abc
        }
        public List<Person> getByAge (int age, List<Person> persons)
        {
            List <Person> agePersons = new List<Person>();
            foreach (Person person in persons)
            {
                if(person.Age > age)
                {
                    agePersons.Add(person);
                }
            }
            return agePersons;
        }
        static void printPersonList(List<Person>people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}