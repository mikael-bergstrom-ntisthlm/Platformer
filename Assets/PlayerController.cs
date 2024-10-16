using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  float jumpForce = 10;

  bool mayJump = true;

  void Update()
  {
    if (Input.GetAxisRaw("Jump") > 0 && mayJump == true)
    {
      Rigidbody2D rb = GetComponent<Rigidbody2D>();
      rb.AddForce(Vector2.up * jumpForce);
      mayJump = false;
    }

  }
}
