using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCuevas : MonoBehaviour
{
    public float runSpeeed=2;
    public float jumpSpeed = 3;
 

    Rigidbody2D rb2D;

    public SpriteRenderer spriteRenderer;
    public Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey ("right"))
        {
            rb2D.velocity = new Vector2(runSpeeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animation.SetBool("Run", true);

        }

        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animation.SetBool("Run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0,rb2D.velocity.y);
            animation.SetBool("Run", false);
        }

        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
        
        if (CheckGround.isGrounded == false)
        {
            animation.SetBool("Jump", true);
            animation.SetBool("Run", false);
        }

        if (CheckGround.isGrounded == true)
        {
            animation.SetBool("Jump", false);
        }
    }
}
