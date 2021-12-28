using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultUI : MonoBehaviour, InventoryUI
{
    public void Notify(Inventory inventory, int slot, Item item)
    {
        Debug.Log(slot + " 슬롯의 아이템이 " + item.Amount + " * " + item.Name + " 으로 바뀜");
    }
}