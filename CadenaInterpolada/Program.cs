var name = "Anderson Ortiz";
Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");





var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
var date = DateTime.Now;
Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price} per{ item.perPackage} items.");
Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:c2} per{ item.perPackage} items.");



var inventory = new Dictionary<string, int>()
{
    ["hammer, ball pein"] = 18,
    ["hammer, cross pein"] = 5,
    ["screwdriver, Phillips #2"] = 14
};
Console.WriteLine($"Inventory on {DateTime.Now:d}");
Console.WriteLine(" ");
Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
foreach (var item1 in inventory)
    Console.WriteLine($"|{item1.Key,-25}|{item1.Value,-10}|");


Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{ 1063.342,15:N2}");