using System;
using System.Collections.Generic;


namespace Library;
public class Character
{
    public string Name { get; set; }

    public Character(string name)
    {
        this.Name = name;
    }

    public void Attack(Character target)
    {
        
    }

    public void Defend()
    {
        
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
