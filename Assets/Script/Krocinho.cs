using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class Krocinho : MonoBehaviour
{
    public float _speed;
    public float _jumpForce;
    public bool _isJumping;
    public bool _doubleJump;
    
    private Rigidbody2D _rgb;

   [SerializeField] CharacterController controller;
   [SerializeField] Vector3 _mover;
   [SerializeField] bool groundedPlayer;
   //[SerializeField] float playerSpeed = 2.0f;
   [SerializeField] float puloHeight = 1.0f;
   private Vector3 playerVelocity;
   private float gravityValue = -9.81f;
   KrocoPonto _playerPontos;

    // Start is called before the first frame update
    void Start()
    {
        _playerPontos = Camera.main.GetComponent<KrocoPonto>();
        _rgb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Move();
        Jump();
        Gravity();
    }

    public void SetMover(inputAction.CallbackContext value)
    {
     _mover = value.ReadValue<Vector3>();
    }

    public void SetPulo(InputAction.CallbackContext value)
    {
        if (groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(puloHeight * -3.0f * gravityValue);
        }
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * _speed;
        if (Input.GetAxis("Horizontal") > 0f)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if (Input.GetAxis("Horizontal") < 0f)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
    }

    void Jump()
    {
      if (Input.GetButtonDown("Jump"))
      {
            if (!_isJumping)
            {
                _rgb.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
                _doubleJump = true;
            }
            else
            {
                if(_doubleJump)
                {
                    _rgb.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
                    _doubleJump = false;
                }
            }
        
      }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            _isJumping = false;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            _isJumping = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.CompareTag("Item"))
      {
         int valorPontos = other.GetComponent<Item>().Valor;
         _playerPontos.SomarPontos(valorPontos);
         other.GetComponent<Item>().DestroyItem();
      }
    }
    
    void Gravity()
    {
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Mover(playerVelocity * Time.deltaTime;
    }
}