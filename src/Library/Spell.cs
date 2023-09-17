using System;
using System.Collections.Generic;

namespace Library;
public class Spell
{
    public string Name { get; set; }

    public Spell(string name)
    {
        this.Name = name;
    }

    public void Cast(Character target)
    {
        
    }
}
