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

            //List<Person> persons = list
            //    .Where(x => x.Age <= 25)
            //    .OrderBy(x => x.Name)
            //    .ToList();
            //Person person = list.First(x => x.Address =="sohar");
            //printPersonList(persons);
            //Console.WriteLine(person);


            List<String> Names = list
                .Where(x => x.Age <= 25)
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
               .ToList();

            foreach( String name in Names )
            {
                Console.WriteLine(name);
            }

            //Person? person = list.FirstOrDefault(x => x.Address == "muscat");
            //if (person != null)
            //{
            //    Console.WriteLine(person.Name);
            //}
            //Console.WriteLine(person?.Name ?? "Hello"); //coalesing operator
            Console.WriteLine("\n\n");
            //------------------------------Student--------------------

            List<Student> studentRecords = new List<Student>
        {
            new Student { Name = "Hamida", Age = 31, Gender = "Female", GPA = 2.8 },
            new Student { Name = "Said", Age = 25, Gender = "Male", GPA = 3.5 },
            new Student { Name = "Nasser", Age = 40, Gender = "Male", GPA = 3.0 },
            new Student { Name = "Nasra", Age = 13, Gender = "Female", GPA = 2.9 },
            new Student { Name = "Rawan", Age = 32, Gender = "Female", GPA = 3.9 },
        };

            // Task 1: Display the list of all students
            Console.WriteLine("List of all students:");
            DisplayStudents(studentRecords);

            // Task 2: Filter and display male students with a GPA greater than 3.5
            Console.WriteLine("\nMale students with a GPA greater than 3.5:");
            var maleStudentsWithHighGPA = highGPAMale(studentRecords, 3.5);
            DisplayStudents(maleStudentsWithHighGPA);

            // Task 3: Find the average GPA of all female students
            double averageGPAOfFemaleStudents = avgGPAFemale(studentRecords);
            Console.WriteLine($"\nAverage GPA of all female students: {averageGPAOfFemaleStudents:F2}");

            // Task 4: Display the names of the top three students with the highest GPA
            Console.WriteLine("\nTop three students with the highest GPA:");
            var topThreeStudents = top3HighestGPA(studentRecords);
            DisplayStudents(topThreeStudents);

            // Task 5: Update the GPA of a specific student
            string studentNameToUpdate = "Said";
            double newGPA = 3.7;
            UpdateStudentGPA(studentRecords, studentNameToUpdate, newGPA);
            Console.WriteLine($"\nUpdated GPA of {studentNameToUpdate} to {newGPA}");

            // Task 6: Remove a student from the list based on their name
            string studentNameToRemove = "Rawan";
            RemoveStudent(studentRecords, studentNameToRemove);
            Console.WriteLine($"\nRemoved student {studentNameToRemove} from the list.");

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

        //----------------------------student---------------------
        static void DisplayStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, GPA: {student.GPA}");
            }
        }

        static List<Student> highGPAMale(List<Student> students, double gpaThreshold)
        {
            List<Student> result = new List<Student>();
            foreach (var student in students)
            {
                if (student.Gender == "Male" && student.GPA > gpaThreshold)
                {
                    result.Add(student);
                }
            }
            return result;
        }

        static double avgGPAFemale(List<Student> students)
        {
            double sumGPA = 0;
            int fMaleCount = 0;
            foreach (var student in students)
            {
                if (student.Gender == "Female")
                {
                    sumGPA += student.GPA;
                    fMaleCount++;
                }
            }
            return fMaleCount > 0 ? sumGPA / fMaleCount : 0;
        }

        static List<Student> top3HighestGPA(List<Student> students)
        {
            students.Sort((s1, s2) => s2.GPA.CompareTo(s1.GPA));
            return students.GetRange(0, Math.Min(students.Count, 3));
        }

        static void UpdateStudentGPA(List<Student> students, string studentName, double newGPA)
        {
            foreach (var student in students)
            {
                if (student.Name == studentName)
                {
                    student.GPA = newGPA;
                    break;
                }
            }
        }

        static void RemoveStudent(List<Student> students, string studentName)
        {
            students.RemoveAll(student => student.Name == studentName);
        }
    }
}
