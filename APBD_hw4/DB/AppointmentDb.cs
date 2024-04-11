using APBD_hw4.DB;
using APBD_hw4.Models;

namespace WebApplication1.DB;

public class AppointmentDb
{
    public static List<Appointment> Db = new()
    {
        new Appointment(new DateTime(2024, 4, 12, 14, 0, 0), AnimalDb.Animals[0], "Routine Checkup", 50.0),
        new Appointment(new DateTime(2024, 4, 13, 10, 30, 0), AnimalDb.Animals[1], "Vaccination", 30.0),
        new Appointment(new DateTime(2024, 4, 14, 16, 0, 0), AnimalDb.Animals[2], "Dental Cleaning", 80.0),
        new Appointment(new DateTime(2024, 4, 15, 11, 0, 0), AnimalDb.Animals[3], "Nail Trimming", 20.0),
        new Appointment(new DateTime(2024, 4, 16, 15, 30, 0), AnimalDb.Animals[4], "General Consultation", 40.0),
    };
} 