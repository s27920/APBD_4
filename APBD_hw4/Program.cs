using APBD_hw4.DB;
using APBD_hw4.Models;
using Microsoft.AspNetCore.Mvc;

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
    return Results.Ok(DB.Animals);
});

program.MapGet("api/animals/{id:int}", (int id) =>
{
    Animal animal = DB.Animals.FirstOrDefault(a => a.Id == id);
    return animal is null ? Results.NotFound() : Results.Ok(animal);
});

program.MapPost("/api/animals", ([FromBody] Animal animal) =>
{
   DB.Animals.Add(animal);
   return Results.Created($"/api/animals{animal.Id}", animal);
});

program.MapPut("/api/animals{id:int}", (int id,[FromBody] Animal animal) =>
{
    Animal animalToCheck = DB.Animals.FirstOrDefault(a => a.Id == id);
    if (animalToCheck is null) return Results.NotFound($"Animal with id {id} not found");
    animalToCheck.Name = animal.Name;
    animalToCheck.Colour = animal.Colour;
    animalToCheck.Weight = animal.Weight;
    animalToCheck.Colour = animal.Colour;
    return Results.Ok(animalToCheck);
});