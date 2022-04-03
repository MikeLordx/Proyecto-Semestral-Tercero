using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private BoxCollider _doorCollider = default;
    [SerializeField] private GameObject _enterPuzzleScreen = default;
    public bool _yesButtonPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        other = _doorCollider;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        _enterPuzzleScreen.SetActive(true);
        Time.timeScale = 0;
        if (_yesButtonPressed)
        {
            InventoryManager.Instance.FindKey();
        }
    }
}


