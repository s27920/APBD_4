namespace APBD_hw4.Models;

public class Appointment
{
    private static int counter = 100;

    private int _id;
    private DateTime _dateTime;
    private Animal _animal;
    private string _description;
    private double _price;

    public Appointment(DateTime dateTime, Animal animal, string description, double price)
    {
        _id = counter++;
        _dateTime = dateTime;
        _animal = animal;
        _description = description;
        _price = price;
    }


    public int Id
    {
        get => _id;
    }

    public DateTime DateTime
    {
        get => _dateTime;
        set => _dateTime = value;
    }

    public Animal Animal
    {
        get => _animal;
        set => _animal = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Description
    {
        get => _description;
        set => _description = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Price
    {
        get => _price;
        set => _price = value;
    }
}