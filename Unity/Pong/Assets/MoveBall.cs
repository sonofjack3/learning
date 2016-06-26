using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {
    private float speed = 30;

	// Use this for initialization
	void Start () {
        // Initial velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}
}
