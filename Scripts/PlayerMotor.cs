using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _playerVelocity;
    
    private bool _isGrounded;
    private bool _lerpCrouch;
    private bool _crouching;
    private bool _sprinting;
    
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 1.5f;
    private float _crouchTimer = 1;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = _controller.isGrounded;
        if (_lerpCrouch)
        {
            _crouchTimer += Time.deltaTime;
            float p = _crouchTimer / 1;
            p *= p;
            if (_crouching)
                _controller.height = Mathf.Lerp(_controller.height, 1, p);
            else
                _controller.height = Mathf.Lerp(_controller.height, 2, p);

        }
    }
    //Receive the inputs for InputManager and apply them to the character controller. 
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        _controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        _playerVelocity.y += gravity * Time.deltaTime;
        if (_isGrounded && _playerVelocity.y < 0)
        {
            _playerVelocity.y = -2f;
        }
        _controller.Move(_playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (_isGrounded)
        {
            _playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }

    public void Crouch()
    {
        _crouching = !_crouching;
        _crouchTimer = 0;
        _lerpCrouch = true;
    }

    public void Sprint()
    {
        _sprinting = !_sprinting;
        if (_sprinting)
            speed = 8;
        else
            speed = 5;
    }
}
