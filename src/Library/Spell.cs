using System;
using System.Collections.Generic;

namespace Library;
public class Spell : Item
{
    public string Name { get; set; }
    public int Power {get; set;}
    public int defensa { get; set; }

    public Spell(string name, int power) 
    {
        this.Name = name;
        this.Power = power;
    }

    public void Cast(Character target)
    {
        
    }
}
