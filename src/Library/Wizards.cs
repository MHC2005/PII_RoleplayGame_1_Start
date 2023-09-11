using System;
using System.Collections.Generic;


namespace Library;
public class Wizard : Character
{
    public List<Spell> Spells { get; set; }
    public Staff MagicalStaff { get; set; }

    public Wizard(string name) : base(name)
    {
        Spells = new List<Spell>();
    }

    public void LearnSpell(Spell spell)
    {
        Spells.Add(spell);
    }
}