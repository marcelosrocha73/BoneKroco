using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngime.InputSystem;


public class Krocinho : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public bool isJumping;
    public bool doubleJump;
    
    private Rigidbody2D _rgb;

   [SerializeField] CharacterController controller;
   [SerializeField] Vector3 _move;
   [SerializeField] bool groundedPlayer;
   [SerializeField] float playerSpeed = 2.0f;
   [SerializeField] float jumpHeight = 1.0f;
   private Vector3 playerVelocity;
   private float gravityValue = -9.81f;
   PlayerPontos _playerPontos;

    // Start is called before the first frame update
    void Start()
    {
        _playerPontos = Camera.main.GetComponent<PlayerPontos>();
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
        //Gravity();
    }

    public void SetMove(inputAction.CallbackContext value)
    {
        _move = value.ReadValue<Vector3>();
    }

    public void SetJump(InputAction.CallbackContext value)
    {
        if (groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
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
            if (!isJumping)
            {
                _rgb.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                doubleJump = true;
            }
            else
            {
                if(doubleJump)
                {
                    _rgb.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                    doubleJump = false;
                }
            }
        
      }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            isJumping = false;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            isJumping = true;
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
    
    //void Gravity()
    //{
    //    playerVelocity.y += gravityValue * Time.deltaTime;
    //    controller.Move(playerVelocity * Time.deltaTime;
    //}
}