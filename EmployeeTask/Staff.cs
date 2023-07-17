namespace EmployeeTask
{
    public class Staff : Person
    {
        private int _salary;

        public int Salary => _salary;

        public override string Name => base.Name + " Staff";

        public Staff(string name, int salary) : base(name)
        {
            _salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"Person {Name} has salary: ${_salary}");
        }
    }
}
