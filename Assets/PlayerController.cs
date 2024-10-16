using System.Collections;
using System.Collections.Generic;
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

  void Update()
  {
    if (Input.GetAxisRaw("Jump") > 0 && mayJump == true)
    {
      Rigidbody2D rb = GetComponent<Rigidbody2D>();
      rb.AddForce(Vector2.up * jumpForce);
      mayJump = false;
    }

    if (Input.GetAxisRaw("Jump") == 0)
    {
      mayJump = true;
    }

    print(IsGrounded());
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
