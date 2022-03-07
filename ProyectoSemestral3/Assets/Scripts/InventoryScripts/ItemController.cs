using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private Item _item = default;
    [SerializeField] private BoxCollider _collider = default;
    [SerializeField] private TextMesh _text = default;
    [SerializeField] private bool _isActive = default;
    [SerializeField] private ItemPickUp _itemPickUp = default;

    private void OnTriggerEnter(Collider other)
    {
        _text.gameObject.SetActive(true);
        _isActive = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _text.gameObject.SetActive(false);
        _isActive = false;
    }

    private void Start()
    {
        _itemPickUp.SetUpItem(_item);
        _text.text = _item._itemName;
    }

    private void Update()
    {
        if (_isActive == true)
        {
            _text.transform.rotation = Camera.main.transform.rotation;
        }
    }
}


