using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private BoxCollider _doorCollider = default;
    [SerializeField] private GameObject _doorMenu;
    private void OnTriggerEnter(Collider other)
    {
        other = _doorCollider;
        _doorMenu.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        _doorMenu.SetActive(false);
    }
}


