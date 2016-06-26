using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour {
    private float speed = 30;
    public string axis = "Vertical";

	// Use this for initialization
	void Start () {
	
	}
	
    // This is called a regular time-interval
	void FixedUpdate () {
        // Define the direction given by the input (-1 for down, 1 for up, 0 for no input)
        float y = Input.GetAxisRaw(axis);

        // Velocity is defined by the direction multipled by the speed
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, y) * speed;
	}
}
