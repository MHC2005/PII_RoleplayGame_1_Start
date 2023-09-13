using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Maru = new Wizard("Maru", 100);
            Wizard Emi = new Wizard("Emi", 100);
            Elf Mateito = new Elf("Mateito", 100);
            Dwarf Frankie = new Dwarf("Frankie", 100);

            Wizard maruWizard = new Wizard("Maru", 15); // Crear un mago llamado "Maru"
            Item someItem = new Item("Caliz de fuego", 5); // Crear un objeto
            maruWizard.AddThings(someItem); // Agregar el objeto al mago

        // Crear elementos
            Spell Confundo = new Spell("Confundo");
            Spell Crucio = new Spell("Crucio");
            Staff Piedra = new Staff("Piedra Filosofal", 20);
            Staff Espada = new Staff("Espada de Godric Gryffindor", 10);

        // Asignar elementos a los personajes
            Emi.AddThings(Piedra);
            Emi.LearnSpell(Confundo);
            Maru.LearnSpell(Crucio);

            Mateito.AddItem(Piedra);

            Frankie.AddWeapon(Espada);

        // Realizar acciones
            Maru.Attack(Mateito, 10); // El mago ataca al elfo con hechizos
            Mateito.Attack(Frankie, 10);   // El elfo ataca al enano con su hacha
            Frankie.Attack(Emi, 5);   // El enano ataca al mago con su hacha

            Console.WriteLine($"{Maru.Name}: Health = {Maru.Health}");
            Console.WriteLine($"{Emi.Name}: Health = {Emi.Health}");
            Console.WriteLine($"{Mateito.Name}: Health = {Mateito.Health}");
            Console.WriteLine($"{Frankie.Name}: Health = {Frankie.Health}");

            //Console.ReadLine();
        }
    }
}
