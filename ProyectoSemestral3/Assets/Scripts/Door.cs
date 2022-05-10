using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private BoxCollider _doorCollider = default;
    [SerializeField] private GameObject _enterPuzzleScreen = default;
    public bool _yesButtonPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        other = _doorCollider;
        _enterPuzzleScreen.SetActive(true);
        InventoryManager.Instance.FindKey();
    }
}


