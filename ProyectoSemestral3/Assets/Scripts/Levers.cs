using UnityEngine;
using UnityEngine.Events;

public class Levers : MonoBehaviour
{
    [SerializeField] private Light _leverLight = default;
    [SerializeField] private UnityEvent _onActivate = new UnityEvent();
    [SerializeField] private GameObject _door1 = default;
    [SerializeField] private GameObject _door2 = default;
    [SerializeField] private GameObject _enemy = default;
    [SerializeField] private AudioSource _audio = default;
    [SerializeField] private bool _active = false;
    private bool _triedActivation = false;

    void Start()
    {
        _leverLight = gameObject.GetComponent<Light>();
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
        gameObject.SetActive(true);
    }

    public void OpenDoors()
    {
        _door1.SetActive(false);
        _door2.SetActive(false);
    }

    public void TurnOfLeverLight()
    {
        _leverLight.enabled = false;
    }

   public void PlaySound()
   {
        _audio.Play();
   }

    public void ActivateEnemy()
    {
        _enemy.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if(_triedActivation)
        {
            ActivateLever();
            _triedActivation = false;
            if(!_triedActivation)
            {
                _active = false;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _triedActivation = true;
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            _triedActivation = false;
        }
    }
}
