#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name; // No warning here due to suppression
        Age = age;   // No warning here because int is not a reference type
    }
}

#pragma warning restore CS8618 // Restore warning to its previous state (optional)
