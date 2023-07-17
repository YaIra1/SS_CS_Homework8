namespace EmployeeTask
{
    public class Student : Person
    {
        private string _groupName;

        public Student(string name, string groupName) : base(name)
        {
            _groupName = groupName;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Student of group: {_groupName}");
        }
    }
}
