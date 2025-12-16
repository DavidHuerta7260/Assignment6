/*
* David Huerta
* Assignment 6
* Manages a list of inventory items.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventoryItem item;
    public List<InventoryItem> inventory;
    
    void Start()
    {
        item = new InventoryItem();
        inventory = new List<InventoryItem>();
    }
}
