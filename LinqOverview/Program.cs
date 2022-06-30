using LinqOverview;

Person[] people =
{
    new Person("Anderson",26),
    new Person("Johnm",30),
    new Person("Cauger",15),
    new Person("Felipe",50)
};


var peopleAnon = new[]
{
    new {Name="Anderson", Age= 26},
    new {Name="Johnm",  Age= 30},
    new {Name="Cauger", Age= 15},
    new {Name="Felipe", Age= 50},
};



var ageQuery = from p in peopleAnon
               where p.Age >= 30
               orderby p.Name ascending
               select p;


IEnumerable<Person> result = people.Where(p=>p.Age>=30).OrderByDescending(p=> p.Name);
var result2 = peopleAnon.Where(p=>p.Age>=30).OrderByDescending(p=> new {Name= p.Name, Age=p.Age });

foreach (var person in ageQuery) 
    Console.WriteLine($"{person.Name} ->>> {person.Age}");