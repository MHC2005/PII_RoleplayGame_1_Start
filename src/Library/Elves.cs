using System;
using System.Collections.Generic;


namespace Library;
public class Elf : Character
{
    public List<Item> Items { get; set; }

    public Elf(string name) : base(name)
    {
        Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }
}