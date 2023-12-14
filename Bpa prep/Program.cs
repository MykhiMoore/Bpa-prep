using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 20 }
        };

        Console.WriteLine("Original list:");
        PrintPeople(people);

        // Sorting by name
        var sortedByName = people.OrderBy(person => person.Name).ToList();

        Console.WriteLine("\nSorted by Name:");
        PrintPeople(sortedByName);

        // Sorting by age
        var sortedByAge = people.OrderBy(person => person.Age).ToList();

        Console.WriteLine("\nSorted by Age:");
        PrintPeople(sortedByAge);
    }

    static void PrintPeople(List<Person> people)
    {
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
