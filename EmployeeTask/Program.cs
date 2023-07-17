namespace EmployeeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Vasyl"),
                new Developer("Bill", 200, DeveloperLevel.TeamLead),
                new Student("Petro", "C#"),
                new Teacher("Zinaida Petrivna", 4000, "Chemistry"),
                new Staff("Grishanya", 3)
            };

            foreach (Person person in people)
            {
                person.Print();
            }
            Console.WriteLine();

            Console.Write("Please enter the name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"All persons with {name} name:");
            foreach (Person person in people.Where(p => p.Name == name))
            {
                person.Print();
            }
            Console.WriteLine();

            Console.WriteLine("Sorted persons by name:");

            people.Sort();

            foreach (Person person in people)
            {
                person.Print();
            }
            Console.WriteLine();

            List<Staff> employees = new List<Staff>();
            foreach (Person person in people)
            {
                if (person is Staff staff)
                {
                    employees.Add(staff);
                }
            }

            Console.WriteLine("Sorted staff:");
            foreach (var staff in employees.OrderBy(e => e.Salary))
            {
                staff.Print();
            }
        }
    }
}