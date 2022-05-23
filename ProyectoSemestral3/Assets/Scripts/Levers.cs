using UnityEngine;
using UnityEngine.Events;

public class Levers : MonoBehaviour
{
    [SerializeField] private Light _leverLight = default;
    [SerializeField] private UnityEvent _onActivate = new UnityEvent();
    [SerializeField] private bool _active = false;
    private bool _onTrigger = false;

    void Start()
    {
        _leverLight = GetComponent<Light>();
        _leverLight.enabled = false;
    }

    public void ActivateLever()
    {
        if (_active == false)
        {
            return;
        }

        _onActivate?.Invoke();
    }

    public void Activate()
    {
        _active = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Felipe");
            Activate();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _onTrigger = false;
    }
}
