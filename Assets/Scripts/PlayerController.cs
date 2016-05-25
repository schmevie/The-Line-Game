using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float playerSpeed = 5.0f;
	private string currentDirection = "None";
	private Vector3 moveDirection = new Vector3 (0, 0, 0);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			moveDirection = Vector3.left;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			moveDirection = Vector3.right;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			moveDirection = Vector3.up;
		} else if (Input.GetKey(KeyCode.DownArrow)) {
			moveDirection = Vector3.down;
		}
		transform.position += moveDirection * playerSpeed * Time.deltaTime;
	}
}
