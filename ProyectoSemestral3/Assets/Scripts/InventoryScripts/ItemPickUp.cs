using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    private Item _item = null;

    public void SetUpItem(Item item)
    {
        _item = item;
    }

    public void Pickup()
    {
        InventoryManager.Instance.AddItem(_item);
        Destroy(gameObject);
    }
}
