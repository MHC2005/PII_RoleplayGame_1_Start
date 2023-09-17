using System;
using System.Collections.Generic;

namespace Library;
public class Spell : Item
{
    //public string Name { get; set; }
    //public int Power {get; set;}

    public Spell(string name, int power) : base(name, power)
    {
        this.Name = name;
        this.Power = power;
    }

    public void Cast(Character target)
    {
        
    }
}
