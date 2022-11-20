using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolaController : MonoBehaviour {
  public Rigidbody2D myRigidbody;
  public float speed = 5f;
  public float horizontalScreenBorder = 12f;
  private Vector2 myVelocity;
  // Start is called before the first frame update
  void Start() {
    myRigidbody = GetComponent<Rigidbody2D>();
    int direction = Random.Range(0, 4);
    switch (direction) {
      case 0:
        myVelocity.Set(speed, speed);
      break;
      case 1:
        myVelocity.Set(-speed, speed);
      break;
      case 2:
        myVelocity.Set(-speed, -speed);
      break;
      case 3:
        myVelocity.Set(speed, -speed);
      break;
      default:
        myVelocity.Set(0, 0);
      break;  
    }
    myRigidbody.velocity = myVelocity;
  }

  // Update is called once per frame
  void Update() {
    float ballX = transform.position.x;
    if (ballX < -horizontalScreenBorder || ballX > horizontalScreenBorder) {
      SceneManager.LoadScene("Jogo");
    }
  }
}

