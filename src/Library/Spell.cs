using System;
using System.Collections.Generic;

namespace Library;
public class Spell
{
    public string Name { get; set; }
    public int power {get; set;}

    public Spell(string name, int power)
    {
        this.Name = name;
        this.Power= power;
    }

    public void Cast(Character target)
    {
        
    }
}
