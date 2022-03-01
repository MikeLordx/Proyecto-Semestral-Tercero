using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager _instance;
    [SerializeField] private List<Item> _items = new List<Item>();
    [SerializeField] private Transform _itemContent;
    [SerializeField] private InventoryView _inventoryViewerItemPrefab;

    private void Awake()
    {
        _instance = this;
    }

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void Remove(Item item)
    {
        _items.Remove(item);
    }

    public void ListItems()
    {
        foreach (Transform item in _itemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in _items)
        {
            InventoryView itemView = Instantiate(_inventoryViewerItemPrefab, _itemContent);
            itemView.Initialize(item);
        }
    }
}



