using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    public int id = default;
    public string itemName = default;
    public string value = default;
    public Sprite icon = default;
    public ItemType itemType = default;
    
    public enum ItemType
    {
        Key,
        Food,
        Card
    }
}



