using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Stats")]
    [Tooltip("Controla la velocidad de movimiento del personaje")]
    [SerializeField]private float _playerSpeed = 5;
    [Tooltip("Controla la fuerza de salto del personaje")]
    [SerializeField]private float _jumpForce = 5;
    private float _playerInputHorizontal;
    private float _playerInputVertical;
    private Rigidbody2D _rBody2D;
    //private GroundSensor _sensor;
    private Animator _animator;
    
    SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponentInChildren<SpriteRenderer>();
       _rBody2D = GetComponent <Rigidbody2D>();
       //_sensor = GetComponentInChildren<GroundSensor>();
       _animator = GetComponentInChildren<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMovement(); 

       if(Input.GetButtonDown("Jump") && GroundSensor._isGrounded)
       {
           Jump();
           
           _animator.SetBool("IsJumping", true);
       }

       _playerInputHorizontal = Input.GetAxis("Horizontal");

        if(_playerInputHorizontal > 0)
        {
            spriterenderer.flipX = false;
        }

        if(_playerInputHorizontal < 0)
        {
            spriterenderer.flipX = true;
        }
    }

    void FixedUpdate()
    {
        //_rBody2D.AddForce(new Vector2(_playerInputHorizontal * _playerSpeed, 0), ForceMode2D.Impulse);

        _rBody2D.velocity = new Vector2(_playerInputHorizontal * _playerSpeed, _rBody2D.velocity.y);
    }

    void PlayerMovement()
    {
        _playerInputHorizontal = Input.GetAxis("Horizontal");

        if(_playerInputHorizontal != 0)
        {
            _animator.SetBool("IsRunning", true);
        }

        if(_playerInputHorizontal == 0)
        {
            _animator.SetBool("IsRunning", false);
        }

        /*_playerInputVertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(_playerInputHorizontal,_playerInputVertical) * _playerSpeed * Time.deltaTime);*/
    }

    void Jump()
    {
         _rBody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

}
