using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    Animator playerAnimator;
    public float moveSpeed = 1f;
    public float jumpSpeed = 1f, jumpFrequency = 1f, nextJumpTime;
    
    bool facingRight = true;
    public bool isGrounded = false;
    public Transform groundCheckPosition;
    public float groundCheckRadius;
    public LayerMask groundCheckLayer;

    void Awake()
    {

    }
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        OnGroundCheck();
        HorizontalMove();
        if(playerRB.velocity.x<0 && facingRight)
        {
           //ayna efekti
           flipFace();
        }
       else if(playerRB.velocity.x>0 && !facingRight)
       {
       //ayna efektini kaldır.
          flipFace();
       }
       if (Input.GetAxis("Vertical")>0 && isGrounded && (nextJumpTime < Time.timeSinceLevelLoad))
       {    
            nextJumpTime = Time.timeSinceLevelLoad + jumpFrequency;
            Jump();  
       }
    
    }
void FixedUpdate()
{

}
void HorizontalMove()
{
    float horizontalInput = Input.GetAxis("Horizontal");
    playerRB.velocity = new Vector2(horizontalInput * moveSpeed, playerRB.velocity.y);

    float currentSpeed = Mathf.Abs(playerRB.velocity.x);
    playerAnimator.SetFloat("playerSpeed", currentSpeed);

}
void flipFace() 
{
     facingRight = !facingRight;

     Vector3 tempLocalScale = transform.localScale;
     tempLocalScale.x *= -1;
     transform.localScale = tempLocalScale;
}

void Jump()
{
    playerRB.AddForce(new Vector2(0f, jumpSpeed ));
}    

void OnGroundCheck()
{
    isGrounded = Physics2D.OverlapCircle(groundCheckPosition.position , groundCheckRadius, groundCheckLayer);
    playerAnimator.SetBool("isGroundedAnim", isGrounded);

}
}
