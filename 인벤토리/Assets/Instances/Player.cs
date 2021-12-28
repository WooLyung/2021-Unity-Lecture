using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, InventoryOwner
{
    Inventory inventory = new Inventory(10);

    public Inventory MyInventory
    {
        get => inventory;
    }

    void Start()
    {
        inventory.AddUI(GameObject.Find("UI").GetComponent<DefaultUI>());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            var item = new Item1();
            item.Amount = 3;
            MyInventory.AddItem(item);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            var item = new Item2();
            item.Amount = 3;
            MyInventory.AddItem(item);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            var item = new Item3();
            item.Amount = 3;
            MyInventory.AddItem(item);
        }
    }
}
