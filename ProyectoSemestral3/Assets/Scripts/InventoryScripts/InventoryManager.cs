using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance { get; private set; }

    [SerializeField] private List<Item> _items = new List<Item>();
    [SerializeField] private Transform _itemContent = default;
    [SerializeField] private InventoryView _inventoryViewerItemPrefab = default;
    [SerializeField] private GameObject _cardCanvas = default;
    private Door _door = default;
    private Item _itemEnum = default;

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
            if (_items[i].itemType == Item.ItemType.Key)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                Time.timeScale = 0;
                _items.RemoveAt(i);
            }
        }
    }

    public void OpenCard()
    {
        switch(_itemEnum.itemType)
        {
            case Item.ItemType.Card:
                _cardCanvas.SetActive(true);
                break;
        }
    }
}



