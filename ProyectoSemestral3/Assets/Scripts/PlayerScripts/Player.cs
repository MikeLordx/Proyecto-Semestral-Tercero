using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _currentHealth;
    public HealthBarScript _healthBar;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _healthBar.SetMaxHealth(_maxHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
        }

        void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            _healthBar.SetHealth(_currentHealth);
        }
    }
}
