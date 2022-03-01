using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    public int _id = default;
    public string _itemName = default;
    public string _value = default;
    public Sprite _icon = default;
}



