using System;
using System.Collections.Generic;


namespace Library;
public class Wizard : Character
{
    public List<Spell> Spells { get; set; }
    public Staff MagicalStaff { get; set; }

    public Wizard(string name, int power) : base(name, power)
    {
        Spells = new List<Spell>();
    }

    public void LearnSpell(Spell spell)
    {
        Spells.Add(spell);
    }
}