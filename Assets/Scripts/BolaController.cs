using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour {
  public Rigidbody2D myRigidbody;
  public float speed = 5f;
  private Vector2 myVelocity;
  // Start is called before the first frame update
  void Start() {
    myRigidbody = GetComponent<Rigidbody2D>();
    myVelocity.x = -speed;
    myRigidbody.velocity = myVelocity;
  }

  // Update is called once per frame
  void Update() {
      
  }
}
