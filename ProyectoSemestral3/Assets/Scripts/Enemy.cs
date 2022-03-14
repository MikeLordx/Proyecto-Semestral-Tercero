using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _iDoDamage = 2;
    [SerializeField] private Component _collider = default;
    [SerializeField] private Player _player = default;
    private float _distance = default;

    private void Start()
    {
        _collider = GetComponent<Collider>();
    }

    private void FixedUpdate()
    {
        _distance = Vector3.Distance(_player.transform.position, _collider.transform.position);
        Debug.DrawRay(transform.position, _player.transform.position.normalized * 15);
        if (_distance < 1)
        {
            _player.TakeDamage(_iDoDamage);
        }
    }
}
