using System;
public class Person{
    private string name;
    private int age;
    public string Name{
        get { return name; }
        set { name = value; }
    }
    public int Age{
        get { return age; }
        set {
            if (value >= 0) age = value;
            else Console.WriteLine("Age cannot be less than 0");
        }
    }  
}
class Program{
    static void Main(){
        Person person = new Person();
        Console.WriteLine("Enter a name for person: ");
        string NewName = Console.ReadLine();
        Console.WriteLine($"Enter {NewName}'s age: ");
        int NewAge = int.Parse(Console.ReadLine());

        person.Name = NewName;
        person.Age = NewAge;
        Console.WriteLine($"\nName: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");
        Console.ReadKey();
    }
}