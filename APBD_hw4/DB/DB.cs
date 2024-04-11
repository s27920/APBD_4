using APBD_hw4.Models;
using Type = APBD_hw4.Models.Type;

namespace APBD_hw4.DB;

public class DB
{
    public static List<Animal> Animals = new()
    {
        new Animal("Buddy", Type.DOG, 5.0, "brown"),
        new Animal("Charlie", Type.CAT, 10.0, "black"),
        new Animal("Max", Type.GUINNEA_PIG, 1.2, "white"),
        new Animal("Oscar", Type.HAMSTER, 1.5, "grey"),
        new Animal("Molly", Type.PARROT, 0.5, "golden"),
        new Animal("Bella", Type.DOG, 3.4, "spotted"),
        new Animal("Lucy", Type.CAT, 4.5, "striped"),
        new Animal("Daisy", Type.GUINNEA_PIG, 2.3, "brown"),
        new Animal("Lola", Type.HAMSTER, 0.9, "black"),
        new Animal("Rocky", Type.PARROT, 11.0, "white"),
        new Animal("Buddy", Type.DOG, 5.0, "grey"),
        new Animal("Charlie", Type.CAT, 10.0, "golden"),
        new Animal("Max", Type.GUINNEA_PIG, 1.2, "spotted"),
        new Animal("Oscar", Type.HAMSTER, 1.5, "striped"),
        new Animal("Molly", Type.PARROT, 0.5, "brown"),
        new Animal("Bella", Type.DOG, 3.4, "black"),
        new Animal("Lucy", Type.CAT, 4.5, "white"),
        new Animal("Daisy", Type.GUINNEA_PIG, 2.3, "grey"),
        new Animal("Lola", Type.HAMSTER, 0.9, "golden"),
        new Animal("Rocky", Type.PARROT, 11.0, "spotted")
    };
}