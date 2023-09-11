using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard gandalf = new Wizard("Gandalf");
            Elf legolas = new Elf("Legolas");
            Dwarf gimli = new Dwarf("Gimli");

        // Crear elementos
            Spell fireballSpell = new Spell("Fireball");
            Spell lightningSpell = new Spell("Lightning");
            Staff magicalStaff = new Staff("Magical-Staff", 20);
            Staff battleAxe = new Staff("Battle Axe", 10);

        // Asignar elementos a los personajes
            gandalf.MagicalStaff = magicalStaff;
            gandalf.LearnSpell(fireballSpell);
            gandalf.LearnSpell(lightningSpell);

            legolas.AddItem(battleAxe);

            gimli.AddWeapon(battleAxe);

        // Realizar acciones
            gandalf.Attack(legolas); // El mago ataca al elfo con hechizos
            legolas.Attack(gimli);   // El elfo ataca al enano con su hacha
            gimli.Attack(gandalf);   // El enano ataca al mago con su hacha

            Console.WriteLine($"{gandalf.Name}: ");
            Console.WriteLine($"{legolas.Name}: ");
            Console.WriteLine($"{gimli.Name}: ");

            Console.ReadLine();
        }
    }
}
