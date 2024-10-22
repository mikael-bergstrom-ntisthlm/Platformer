using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  float jumpForce = 10;

  bool mayJump = true;

  [SerializeField]
  Transform groundChecker;

  [SerializeField]
  LayerMask groundLayer;

  [SerializeField]
  float moveSpeed = 5;

  void Update()
  {
    float xMove = Input.GetAxisRaw("Horizontal");

    Rigidbody2D rb = GetComponent<Rigidbody2D>();

    // Vector2 vel = rb.velocity;
    // vel.x = xMove * moveSpeed;
    // rb.velocity = vel;

    rb.velocity = new Vector2(
      xMove * moveSpeed,
      rb.velocity.y
    );



    if (Input.GetAxisRaw("Jump") > 0 && mayJump == true && IsGrounded())
    {
      rb.AddForce(Vector2.up * jumpForce);
      mayJump = false;
    }

    if (Input.GetAxisRaw("Jump") == 0)
    {
      mayJump = true;
    }

    if (rb.velocity.x > 0)
    {
      GetComponent<SpriteRenderer>().flipX = false;
    }

    if (rb.velocity.x < 0)
    {
      GetComponent<SpriteRenderer>().flipX = true;
    }
  }

  private bool IsGrounded()
  {
    if (Physics2D.OverlapCircle(groundChecker.position, .2f, groundLayer))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
