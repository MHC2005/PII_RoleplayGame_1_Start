using System;
using System.Collections.Generic;

namespace Library;
public class Character
{
    public string Name { get; set; }
    public int  MaxHealth { get; set; }
    public int Health { get; set; }

    public Character(string name, int maxHealth)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth; // Health se inicializa con el valor de MaxHealth
    }

    public void Attack(Character target, int attackPower)
    {
        target.Health -= attackPower;
    }

    public void Defend(int defensePower)
    {
        this.Health = Math.Min(this.MaxHealth, this.Health + defensePower);
    }
}

public class Item //sería el arma o el libro de hechizos o lo que sea
{
    public string Name { get; set; }
    public int Power { get; set; }

    public Item(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }
}
