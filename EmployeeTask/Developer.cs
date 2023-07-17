namespace EmployeeTask
{
    internal class Developer : Staff
    {
        private DeveloperLevel _level;
        public Developer(string name, int salary, DeveloperLevel level) : base(name, salary)
        {
            _level = level;
        }

        public override void Print()
        {
            Console.WriteLine($"The developer {Name} with level {_level} has a salary: $ {Salary}");
        }
    }
}
