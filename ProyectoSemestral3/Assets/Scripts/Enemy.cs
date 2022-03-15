using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _iDoDamage = 2;
    [SerializeField] private Component _collider = default;
    [SerializeField] private Player _player = default;
    private float _distanceToPlayer = default;

    private void Start()
    {
        _collider = GetComponent<Collider>();
    }

    private void FixedUpdate()
    {
        _distanceToPlayer = Vector3.Distance(_player.transform.position, _collider.transform.position);
        Debug.DrawRay(transform.position, _player.transform.position.normalized * 15);
        if (_distanceToPlayer < 3)
        {
            _player.TakeDamage(_iDoDamage);
        }
    }
}
