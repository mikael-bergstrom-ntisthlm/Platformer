using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  [SerializeField]
  Transform player;

  Vector3 offset;

  void Start()
  {
    offset = transform.position - player.position;
  }

  void Update()
  {
    Vector3 pos = transform.position;
    pos.x = player.position.x + offset.x;
    transform.position = pos;

    // transform.position = player.position + offset;
  }
}
