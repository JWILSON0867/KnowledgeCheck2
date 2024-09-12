using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<MyBaseClass>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myObject = new MyInheritedClass();

            Console.WriteLine("Enter the value for myProperty: ");
            myObject.myProperty = Console.ReadLine();

            Console.WriteLine("Enter the value for inheritedProperty: ");
            myObject.inheritedProperty = Console.ReadLine();

            recordList.Add(myObject);
        }

        // Print out the list of records
        Console.WriteLine("List of records:");
        foreach (var record in recordList)
        {
            Console.WriteLine($"myProperty: {record.myProperty}, inheritedProperty: {(record is MyInheritedClass obj ? obj.inheritedProperty : "N/A")}");
        }
    }
}

class MyBaseClass
{
    public string myProperty { get; set; }
}

class MyInheritedClass : MyBaseClass
{
    public string inheritedProperty { get; set; }
}

