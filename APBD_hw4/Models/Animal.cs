namespace APBD_hw4.Models;

public class Animal
{
    static private int counter = 100;
    private int id;
    private string _name;
    private Type _specie;
    private double _weight;
    private string _colour;

    public Animal(string name, Type specie, double weight, string colour)
    {
        id = counter++;
        _name = name;
        _specie = specie;
        _weight = weight;
        _colour = colour;
    }

    public int Id
    {
        get => id;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Type Specie
    {
        get => _specie;
        set => _specie = value;
    }

    public double Weight
    {
        get => _weight;
        set => _weight = value;
    }

    public string Colour
    {
        get => _colour;
        set => _colour = value ?? throw new ArgumentNullException(nameof(value));
    }
}