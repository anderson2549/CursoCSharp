using MethodExtension;

int[] numbers = { 1, 23, 4, 2, 2, 3, 4, 5, 6, 7 };

Console.WriteLine($"Suma {numbers.Sum()} ");
Console.WriteLine($"Promedio {numbers.Average()} ");
Console.WriteLine($"Max {numbers.Max()} ");
Console.WriteLine($"Min {numbers.Min()} ");
//Console.WriteLine($"Peer {number.Pair()} ");
//Console.WriteLine($"Min {number.Min()} ");
Console.WriteLine("Peer");

var numberPairs = numbers.Where(x => x.IsPeer()).Distinct();

foreach(var number in numberPairs)
{
    Console.WriteLine(number);
}


var peoples = new[]
{
    new Person("Anderson"),
    new Person("Mayer"),
    new Person("Cristian")
};

foreach(var people in peoples)
{
    Console.WriteLine($"{people.FullName("Bogota")}");
}
