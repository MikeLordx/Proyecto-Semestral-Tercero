using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private BoxCollider _doorCollider = default;

    private void OnTriggerEnter(Collider other)
    {
        other = _doorCollider;
        InventoryManager.Instance.FindKey();
    }
}


