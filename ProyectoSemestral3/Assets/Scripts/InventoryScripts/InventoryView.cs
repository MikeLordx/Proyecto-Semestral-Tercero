using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    public Image _itemIcon;
    public Text _itemName;

    public void Initialize(Item item)
    {
        _itemIcon.sprite = item._icon;
        _itemName.text = item._itemName;
    }
}



