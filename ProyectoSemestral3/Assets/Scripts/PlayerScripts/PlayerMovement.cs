using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;
    [SerializeField] private Transform _cam = default;
    [SerializeField] private float _speed = 6f;
    [SerializeField] private float _turnTime = 0.1f;
    [SerializeField] float _directionDeadZone = 0.1f;
    private float _runningSpeed = 12f;
    private float _speedDecrement = 6f;
    float _turnVelocity = default;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        if (direction.magnitude >= _directionDeadZone)
        {
            float targAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + _cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targAngle, ref _turnVelocity, _turnTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 movingDir = Quaternion.Euler(0f, targAngle, 0f) * Vector3.forward;
            _controller.Move(movingDir.normalized * _speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _speed = _runningSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed = _speedDecrement;
        }
        
    }
}


