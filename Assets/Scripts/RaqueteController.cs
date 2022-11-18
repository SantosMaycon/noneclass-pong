using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour {
  private Vector3 myPosition;
  public float myY;
  public float speed = 5f;
  public float racketLimit = 3.5f;
  public bool isPlayer1;
  // Start is called before the first frame update
  void Start() {
    myPosition = transform.position;
  }

  // Update is called once per frame
  void Update() {
    myPosition.y = myY;
    transform.position = myPosition;

    float deltaSpeed = speed * Time.deltaTime;

    if(Input.GetKey(KeyCode.UpArrow) && isPlayer1) {
      myY += deltaSpeed;
    }

    if(Input.GetKey(KeyCode.DownArrow) && isPlayer1) {
      myY -= deltaSpeed;
    }

    if(Input.GetKey(KeyCode.W) && !isPlayer1) {
      myY += deltaSpeed;
    }

    if(Input.GetKey(KeyCode.S) && !isPlayer1) {
      myY -= deltaSpeed;
    }

    if (myY < -racketLimit) {
      myY = -racketLimit;
    }

    if (myY > racketLimit) {
      myY = racketLimit;
    }
  }
}
