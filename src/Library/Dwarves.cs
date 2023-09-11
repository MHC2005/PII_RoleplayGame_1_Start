using System;
using System.Collections.Generic;


namespace Library;

public class Dwarf : Character
{
    public List<Item> DwarfItems { get; set; }

    public Dwarf(string name) : base(name)
    {
        this.DwarfItems = new List<Item>();
    }

    public void AddWeapon(Item weapon)
    {
        DwarfItems.Add(weapon);
    }
}