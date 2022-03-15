using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _currentHealth = default;
    [SerializeField] private HealthBarScript _healthBar = default;
    [SerializeField] private GameObject _deadPanel = default;
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


