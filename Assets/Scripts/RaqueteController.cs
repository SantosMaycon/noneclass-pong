using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour {
  private Vector3 myPosition;
  public float speed = 5f;
  public float myY;
  // Start is called before the first frame update
  void Start() {
    myPosition = transform.position;
  }

  // Update is called once per frame
  void Update() {
    myPosition.y = myY;
    transform.position = myPosition;

    if(Input.GetKey(KeyCode.UpArrow)) {
      myY += speed * Time.deltaTime;
    }

    if(Input.GetKey(KeyCode.DownArrow)) {
      myY -= speed * Time.deltaTime;
    }
  }
}
