using System.Collections.Generic;
using IntroEntityFramework.Models;

Console.WriteLine("Hello, World!");

SystemContext context = new SystemContext();

// A título de testes, vamos utilizar migrations no projeto ASP.NET CORE
context.Database.EnsureCreated();

// CRIAR ('C'RUD)
// Computer c1 = new Computer(1, "2GB", "i3");
// context.Computers.Add(c1);
// context.SaveChanges();

// Computer c2 = new Computer(2, "3GB", "i5");
// context.Computers.Add(c2);
// context.SaveChanges();

// Computer c3 = new Computer(3, "5GB", "i9");
// context.Computers.Add(c3);
// context.SaveChanges();

IEnumerable<Computer> computers = context.Computers.ToList();

// Ler (C'R'UD)
foreach (var comp in computers)
{
    Console.WriteLine($"{comp.Id}, {comp.Ram}, {comp.Processor}");
}

// Ler (C'R'UD)
Computer encontrado = context.Computers.Find(3);
Console.WriteLine($"Encontrado com Id 3: {encontrado.Ram}, {encontrado.Processor}");

// Atualizar (CR'U'D)
encontrado.Ram = "10GB";
encontrado.Processor = "amd";
context.Computers.Update(encontrado);
context.SaveChanges();

Computer atualizado = context.Computers.Find(3);
Console.WriteLine($"Atualizado com Id 3: {atualizado.Ram}, {atualizado.Processor}");

// Remover (CRU'D')
context.Computers.Remove(atualizado);
context.SaveChanges();