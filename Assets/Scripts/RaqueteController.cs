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



    if(Input.GetKey(KeyCode.UpArrow) && myY < racketLimit && isPlayer1) {
      myY += speed * Time.deltaTime;
    }

    if(Input.GetKey(KeyCode.DownArrow) && myY > -racketLimit && isPlayer1) {
      myY -= speed * Time.deltaTime;
    }

    if(Input.GetKey(KeyCode.W) && myY < racketLimit && !isPlayer1) {
      myY += speed * Time.deltaTime;
    }

    if(Input.GetKey(KeyCode.S) && myY > -racketLimit && !isPlayer1) {
      myY -= speed * Time.deltaTime;
    }
  }
}
