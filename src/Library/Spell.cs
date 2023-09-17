using System;
using System.Collections.Generic;

namespace Library;
public class Spell : Item
{
    public string Name { get; set; }
    public int Power {get; set;}
    public int Defensa { get; set; }
    
    private List<Spell> book;


    public Spell(string name, int power, int defensa) 
    {
        this.Name = name;
        this.Power = power;
        this.Defensa = defensa;
        book = new List<Spell>();
    }
    
    public void AddSpellToBook(Spell spell)
    {
        book.Add(spell);
    }

    public void RemoveSpellFromBook(Spell spell)
    {
        book.Remove(spell);
    }

    public void ModifySpellInBook(Spell oldSpell, Spell newSpell)
    {
        if (book.Contains(oldSpell))
        {
            book.Remove(oldSpell);
            book.Add(newSpell);
        }
    }

    public List<Spell> GetSpellsInBook()
    {
        return book;
    }
}
