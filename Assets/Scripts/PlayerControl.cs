using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour

{
    public float speed = 5f;
    private float movement = 0f;
    public float jumpSpeed = 5f;
    private Rigidbody2D rigidBody; 

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    public GameObject Button; //кнопка перезапуску

    
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        movement = Input.GetAxis ("Horizontal"); //

        if(movement > 0f){
            rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
        }
        else if (movement < 0f){
            rigidBody.velocity = new Vector2(movement*speed, rigidBody.velocity.y);
        }
        else {
            rigidBody.velocity = new Vector2 (0, rigidBody.velocity.y);
        }
        if(Input.GetButtonDown ("Jump") && isTouchingGround == true){
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
          
    }

      private void OnCollisionEnter2D(Collision2D collision) //Кнопка перезапуску
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            Button.SetActive(true);
        }
    }
}

