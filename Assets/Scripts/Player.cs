using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour {

    private Rigidbody2D rb2d;

    public float MIN_HORIZONTAL_DEADBAND = -0.2f;
    public float MAX_HORIZONTAL_DEADBAND = 0.2f;

    public float Negative_Bound_X = -4f;
    public float Positive_Bound_X = 4f;

	void Start () {
        rb2d = this.GetComponent<Rigidbody2D>();
    }
	
	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        if(horizontal > MIN_HORIZONTAL_DEADBAND && horizontal < MAX_HORIZONTAL_DEADBAND)
        {
            horizontal = 0;
        }

        rb2d.velocity = new Vector2(horizontal, 0);

        if (rb2d.position.x >= Positive_Bound_X)
        {
            rb2d.position = new Vector3(Positive_Bound_X, rb2d.position.y);
        }
        else if (rb2d.position.x <= Negative_Bound_X)
        {
            rb2d.position = new Vector3(Negative_Bound_X, rb2d.position.y);
        }
    }
}
