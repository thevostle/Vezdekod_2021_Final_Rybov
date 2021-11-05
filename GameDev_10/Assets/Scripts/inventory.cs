using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    private GameObject[] items;

    // словарь id -> count
    Dictionary<int, int> resources = new Dictionary<int, int>(3);

    public void InitInventory()
    {
        resources.Add(1, 0); // дерево
        resources.Add(2, 0); // камень
        resources.Add(3, 0); // железо
    }

    public void AddItem(item item, int count)
    {
        resources[item.id] += count;
    }

    public void UseItem(item item, int count)
    {
        if (resources[item.id] >= count)
            resources[item.id] -= count;
    }
}
