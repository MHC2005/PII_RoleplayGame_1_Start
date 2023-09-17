using System;
using System.Collections.Generic;


namespace Library;
public class Staff : Item
{

    public string Name { get; set; }
    public int Power { get; set; }
    public int Defensa { get; set; }
    public List<Item> Stafff { get; set; }
    public Staff(string name, int power, int defensa)  //estas son las cosas, tipo armas y libros
    {
        this.Name = name;
        this.Power = power;
        this.Defensa = defensa;
    }

    public void AddItem(Item staff)
        {
            Stafff.Add(staff);
        }

    public void RemoveItem(Item staff)
        {
            Stafff.Remove(staff);
        }

    public void ChangeItem(Item currentStaff, Item newStaff)
        {
            if (Stafff.Contains(currentStaff))
            {
                Stafff.Remove(currentStaff);
                Stafff.Add(newStaff);
            }
        }
}