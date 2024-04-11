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
}