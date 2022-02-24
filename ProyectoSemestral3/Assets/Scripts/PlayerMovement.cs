using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;
    [SerializeField] private Transform cam;
    [SerializeField] private float _speed = 6f;
    [SerializeField] private float _turnTime = 0.1f;
    float _turnVelocity;

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        if(direction.magnitude >= 0.1f)
        {
            float targAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targAngle, ref _turnVelocity, _turnTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 movingDir = Quaternion.Euler(0f, targAngle, 0f) * Vector3.forward;
            _controller.Move(movingDir.normalized * _speed * Time.deltaTime);
        }
    }
}
