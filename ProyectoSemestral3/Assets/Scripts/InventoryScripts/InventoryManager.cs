using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> items = new List<Item>();
    public Transform _itemContent;
    public InventoryView _inventoryViewerItemPrefab;

    private void Awake()
    {
        Instance = this;
    }

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void Remove(Item item)
    {
        items.Remove(item);
    }

    public void ListItems()
    {
        foreach (Transform item in _itemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in items)
        {
            InventoryView itemView = Instantiate(_inventoryViewerItemPrefab, _itemContent);
            itemView.Initialize(item);
        }
    }

}
