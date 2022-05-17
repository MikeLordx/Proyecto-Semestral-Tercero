using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    public Image _itemIcon = default;
    public Text _itemName;

    public void Initialize(Item item)
    {
        _itemIcon.sprite = item.icon;
        _itemName.text = item.itemName;
    }
}



