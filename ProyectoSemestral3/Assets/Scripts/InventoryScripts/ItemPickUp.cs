using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item Item;

    void Pickup()
    {
        InventoryManager._instance.AddItem(Item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Pickup();
    }
}
