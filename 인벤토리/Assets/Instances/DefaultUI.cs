using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultUI : MonoBehaviour, InventoryUI
{
    public void Notify(Inventory inventory, int slot, Item item)
    {
        Debug.Log(slot + " ������ �������� " + item.Amount + " * " + item.Name + " ���� �ٲ�");
    }
}