using System;
using System.Collections.Generic;

namespace Library;
public interface Item //sería el arma o el libro de hechizos o lo que sea
{
    public string Name { get; set; }
    public int Power { get; set; }

    public int Defensa { get; set; }

    public void AddItem(Item item);

    public void RemoveItem(Item item);

    public void ChangeItem(Item currentItem, Item newItem);



    
}
