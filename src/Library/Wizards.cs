using System;
using System.Collections.Generic;

namespace Library;
public class Wizard : Character
{
    public List<Spell> Spells { get; set; }
    public List<Item> WizardItems { get; set; }

    public Wizard(string name, int maxHealth, int power) : base(name, maxHealth)
    {
        Spells = new List<Spell>();
        WizardItems = new List<Item>(); // Inicializa la lista WizardItems
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
