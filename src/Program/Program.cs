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
            Spell fireballSpell = new Spell("Fireball");
            Spell lightningSpell = new Spell("Lightning");
            Staff magicalStaff = new Staff("Magical-Staff", 20);
            Staff battleAxe = new Staff("Battle Axe", 10);

        // Asignar elementos a los personajes
            Emi.MagicalStaff = magicalStaff;
            Emi.LearnSpell(fireballSpell);
            Emi.LearnSpell(lightningSpell);

            Mateito.AddItem(battleAxe);

            Frankie.AddWeapon(battleAxe);

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
