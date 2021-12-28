using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    int _size;
    readonly List<Item> items;
    List<InventoryUI> inventoryUIs = new List<InventoryUI>();

    public int Size { get => _size; }

    public Inventory(int size)
    {
        _size = size;
        items = new List<Item>();
        for (int i = 0; i < _size; i++)
            items.Add(null);
    }

    public void AddUI(InventoryUI ui)
    {
        inventoryUIs.Add(ui);
    }

    public void AddItem(Item item)
    {
        Item clone = item.Clone();

        for (int i = 0; i < _size; i++)
        {
            if (clone.Amount == 0)
                break;

            if (items[i] == null)
            {
                items[i] = clone.Clone();
                clone.Amount = 0;
                Notify(i, items[i]);
            }
            else if (items[i].GetType() == item.GetType() && items[i].Amount != items[i].MaxStack)
            {
                int tmp = items[i].Amount;
                items[i].Amount += clone.Amount;
                clone.Amount -= items[i].Amount - tmp;
                Notify(i, items[i]);
            }
        }
    }

    void Notify(int slot, Item item)
    {
        foreach (var ui in inventoryUIs)
            ui.Notify(this, slot, item);
    }
}