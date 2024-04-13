using Tutorial4.Database;
namespace Tutorial4.Models;

public class Animal
{
    private static int counter = 0;
    public Animal(string name, string category, double weight, string hairColor)
    {
        Id = counter++;
        Name = name;
        Category = category;
        Weight = weight;
        Hair_color = hairColor;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string Hair_color { get; set;}
    
}