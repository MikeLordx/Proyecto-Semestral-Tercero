using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance { get; private set; }

    [SerializeField] private List<Item> _items = new List<Item>();
    [SerializeField] private Transform _itemContent;
    [SerializeField] private InventoryView _inventoryViewerItemPrefab;

    private void Awake()
    {
        Instance = this;
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

    public void FindKey()
    {
        for(int i = 0; i < _items.Count; i++)
        {
            if (_items[i]._itemType == Item.ItemType.Key)
            {
                Debug.Log("Lo conseguiste");
                _items.RemoveAt(i);
            }
            else
            {
                Debug.Log("You need to find a key");
            }
        }
    }
}



