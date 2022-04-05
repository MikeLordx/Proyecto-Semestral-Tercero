using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private BoxCollider _doorCollider = default;
    public bool _yesButtonPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        other = _doorCollider;
        InventoryManager.Instance.FindKey();
    }
}


