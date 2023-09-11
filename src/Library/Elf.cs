using System;
using System.Collections.Generic;


namespace Library;
public class Elf : Character
{
    public List<Item> ElfItems { get; set; }

    public Elf(string name, int power) : base(name, power)
    {
        ElfItems = new List<Item>();
    }

    public void AddItem(Item item)
    {
        ElfItems.Add(item);
    }
}