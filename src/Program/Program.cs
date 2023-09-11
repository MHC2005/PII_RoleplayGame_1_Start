using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Maru = new Wizard("Maru", 15);
            Wizard Emi = new Wizard("Emi", 15);
            Elf Mateito = new Elf("Mateito", 10);
            Dwarf Frankie = new Dwarf("Frankie", 5);

        // Crear elementos
            Spell Confundo = new Spell("Confundo");
            Spell Crucio = new Spell("Crucio");
            Staff Piedra = new Staff("Piedra Filosofal", 20);
            Staff Espada = new Staff("Espada de Godric Gryffindor", 10);

        // Asignar elementos a los personajes
            Emi.MagicalStaff = Piedra;
            Emi.LearnSpell(Confundo);
            Maru.LearnSpell(Crucio);

            Mateito.AddItem(Piedra);

            Frankie.AddWeapon(Espada);

        // Realizar acciones
            Maru.Attack(Mateito); // El mago ataca al elfo con hechizos
            Mateito.Attack(Frankie);   // El elfo ataca al enano con su hacha
            Frankie.Attack(Emi);   // El enano ataca al mago con su hacha

            Console.WriteLine($"{Maru.Name}: ");
            Console.WriteLine($"{Emi.Name}: ");
            Console.WriteLine($"{Mateito.Name}: ");
            Console.WriteLine($"{Frankie.Name}: ");

            Console.ReadLine();
        }
    }
}
