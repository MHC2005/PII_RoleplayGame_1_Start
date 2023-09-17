using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard maru = new Wizard("Maru", 100, 15);
            Wizard emi = new Wizard("Emi", 100, 20);
            Elf mateito = new Elf("Mateito", 100, 10);
            Dwarf frankie = new Dwarf("Frankie", 100, 12);

            // Crear elementos
            Spell confundo = new Spell("Confundo", 12, 10);
            Spell crucio = new Spell("Crucio", 10, 8);
            Staff piedra = new Staff("Piedra Filosofal", 20, 18);
            Staff espada = new Staff("Espada de Godric Gryffindor", 10, 8);

            // Asignar elementos a los personajes
            emi.AddItem(piedra);
            emi.AddSpell(confundo);

            maru.AddItem(Snitch Dorada);
            maru.AddSpell(crucio);

            mateito.AddItem(piedra);

            frankie.AddItem(espada);

            // Realizar acciones
            maru.Attack(mateito, crucio); // El mago "Maru" ataca al elfo con hechizos
            mateito.Attack(frankie, piedra);   // El elfo ataca al enano con su hacha
            frankie.Attack(emi, espada);   // El enano ataca al mago "Emi" con su hacha



            Console.WriteLine($"{maru.Name}: Health = {maru.Health}");
            Console.WriteLine($"{emi.Name}: Health = {emi.Health}");
            Console.WriteLine($"{mateito.Name}: Health = {mateito.Health}");
            Console.WriteLine($"{frankie.Name}: Health = {frankie.Health}");

            Console.ReadLine();
        }
    }
}
