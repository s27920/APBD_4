using APBD_hw4.DB;
using APBD_hw4.Models;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DB;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var program = builder.Build();

if (program.Environment.IsDevelopment())
{
    program.UseSwagger();
    program.UseSwaggerUI();
    
}

program.MapGet("api/animals", () =>{
    return Results.Ok(AnimalDb.Animals);
});

program.MapGet("api/animals/{id:int}", (int id) =>
{
    Animal animal = AnimalDb.Animals.FirstOrDefault(a => a.Id == id);
    return animal is null ? Results.NotFound() : Results.Ok(animal);
});

program.MapPost("/api/animals", ([FromBody] Animal animal) =>
{
   AnimalDb.Animals.Add(animal);
   return Results.Created($"/api/animals{animal.Id}", animal);
});

program.MapPut("/api/animals{id:int}", (int id,[FromBody] Animal animal) =>
{
    Animal animalToCheck = AnimalDb.Animals.FirstOrDefault(a => a.Id == id);
    if (animalToCheck is null) return Results.NotFound($"Animal with id {id} not found");
    animalToCheck.Name = animal.Name;
    animalToCheck.Colour = animal.Colour;
    animalToCheck.Weight = animal.Weight;
    animalToCheck.Colour = animal.Colour;
    return Results.Ok(animalToCheck);
});

program.MapDelete("/api/animals/{id:int}", (int id) =>
{
    var animals = AnimalDb.Animals.Where(st => st.Id != id);
    AnimalDb.Animals = animals.ToList();
    return Results.Ok();
});

program.MapGet("/api/animals/{id:int}/appointments", (int id) =>
{
    var appointments = AppointmentDb.Db.Where(a => a.Id == id);
    return Results.Ok(appointments.ToList());
});

program.MapPost("/api/animals/{id:int}/appointments", 
    (int id, [FromBody] Appointment appointment) =>
    {
        AppointmentDb.Db.Add(appointment);
        return Results.Created($"/api/animals{appointment.Id}", appointment);
    });

program.MapControllers();

program.UseHttpsRedirection();

program.Run();