using System;
using System.Collections.Generic;

namespace Library;
public class Spell : Item
{
    public string Name { get; set; }
    public int Power {get; set;}
    public int Defensa { get; set; }
    public List<Item> Spells { get; set; }

    public Spell(string name, int power, int defensa) 
    {
        this.Name = name;
        this.Power = power;
        this.Defensa = defensa;
    }
    public void AddItem(Item spell)
        {
            Spells.Add(spell);
        }

    public void RemoveItem(Item spell)
        {
            Spells.Remove(spell);
        }

    public void ChangeItem(Item currentSpell, Item newSpell)
        {
            if (Spells.Contains(currentSpell))
            {
                Spells.Remove(currentSpell);
                Spells.Add(newSpell);
            }
        }
}
