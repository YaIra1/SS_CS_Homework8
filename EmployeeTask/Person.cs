namespace EmployeeTask
{
    public class Person : IComparable<Person>
    {
        private string _name;

        public virtual string Name => _name;

        public Person(string name)
        {
            _name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name {_name}");
        }

        public int CompareTo(Person? other)
        {
            ArgumentNullException.ThrowIfNull(other);

            return _name.CompareTo(other._name);
        }
    }
}
