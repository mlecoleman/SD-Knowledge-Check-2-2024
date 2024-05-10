
using KnowledgeCheckTwo;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Bicycle>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var bicycle = new Bicycle();

    Console.WriteLine("What is the make of the bicycle?");
    bicycle.Make = Console.ReadLine();

    Console.WriteLine("Enter the value for number of tires.");
    bicycle.NumberOfTires = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the value for number of riders.");
    bicycle.NumberOfRiders = int.Parse(Console.ReadLine());

    recordList.Add(bicycle);
}

foreach (Bicycle bicycle in recordList)
{
    Console.WriteLine($"Bicycle of Make: {bicycle.Make} with {bicycle.NumberOfTires} Tire(s) and a rider capacity of {bicycle.NumberOfRiders} ");
}

Console.ReadKey();

