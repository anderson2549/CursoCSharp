namespace MethodExtension
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public int Id { get => new Random(DateTime.Now.Millisecond).Next(1000, 9999); }
    }
}
