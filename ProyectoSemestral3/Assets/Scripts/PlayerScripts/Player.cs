using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _currentHealth = default;
    [SerializeField] private HealthBarScript _healthBar = default;
    [SerializeField] private GameObject _deadPanel = default;
    [SerializeField] private Camera _cam = default;
    private int _iDied = 0;
    private bool _isDead = false;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _healthBar.SetMaxHealth(_maxHealth);
    }

    private void FixedUpdate()
    {
        DeadEvent();
    }
    private void Update()
    {
        Ray ray = _cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                var itemPickUp = hit.collider.gameObject.GetComponent<ItemPickUp>();
                itemPickUp.Pickup();
            }
        }
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        _healthBar.SetHealth(_currentHealth);
    }

    private void DeadEvent()
    {
        if (_currentHealth == _iDied)
        {
            _isDead = true;
            _deadPanel.SetActive(true);
        }
    }
}

