using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private BoxCollider _doorCollider = default;
    [SerializeField] private GameObject _doorMenu = default;

    private void OnTriggerEnter(Collider other)
    {
        other = _doorCollider;
        _doorMenu.SetActive(true);
        InventoryManager.Instance.FindKey();
    }

    private void OnTriggerExit(Collider other)
    {
        _doorMenu.SetActive(false);
    }
}


