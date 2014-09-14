using UnityEngine;
using System.Collections;

public class back_and_forth : MonoBehaviour {

	public string hello;
	public float speed = 7;
	public float leftborder = -5;
	public float rightborder = 5;



	// Use this for initialization
	void Start () {
		print (hello);
		rigidbody2D.velocity = new Vector2 (speed, 0);
		leftborder = leftborder + transform.position.x;
			rightborder = rightborder + transform.position.x;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x > rightborder) {
			rigidbody2D.velocity = new Vector2 (-speed, -1);
		}
		if (transform.position.x < leftborder){
			rigidbody2D.velocity = new Vector2 (speed, -1);
		}

	}

}		