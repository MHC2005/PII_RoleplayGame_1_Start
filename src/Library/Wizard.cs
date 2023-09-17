using System;
using System.Collections.Generic;


namespace Library;
public class Wizard : Character
{
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public List<Spell> Spells { get; set; }
    public List<Item> WizardItems { get; set; }
    

    public Wizard(string name, int maxHealth, int power) 
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Spells = new List<Spell>();
        WizardItems = new List<Item>(); // Inicializa la lista WizardItems
    }
    
    public void Attack(Character target, int attackPower)
        {
            target.Health -= attackPower;
        }

        public void Defend(int defensePower)
        {
            Health = Math.Min(MaxHealth, Health + defensePower);
        }

    public void AddThings(Item item)
    {
        WizardItems.Add(item);

    }
    public void LearnSpell(Spell spell)
    {
        Spells.Add(spell);
    }
}

   
