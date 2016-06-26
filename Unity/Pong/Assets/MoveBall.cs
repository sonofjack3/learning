using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {
    private float speed = 30;

	// Use this for initialization
	void Start () {
        // Initial velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
	}

    void OnCollisionEnter2D(Collision2D col) {
        // "col" holds the collision information
        // For example, when the ball collides with a racket:
        //  col.gameObject is the racket
        //  col.transform.position is the racket's position
        //  col.collider is the racket's collider

        switch (col.gameObject.name) {
            case "RacketLeft":
                calculateVelocity(col, 1);
                break;
            case "RacketRight":
                calculateVelocity(col, -1);
                break;
        }
    }

    void calculateVelocity(Collision2D col, int direction) {
        // Calculate the hit factor
        float y = hitFactor(transform.position,
                            col.transform.position,
                            col.collider.bounds.size.y);

        // Use normalized to make the direction vector equal to 1
        Vector2 dir = new Vector2(direction, y).normalized;

        // Calculate velocity
        GetComponent<Rigidbody2D>().velocity = dir * speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight) {
        return (ballPos.y - racketPos.y) / racketHeight;
    }
}
