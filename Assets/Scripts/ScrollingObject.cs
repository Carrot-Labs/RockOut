using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0, GameControl.instance.scrollSpeed);
    }

    void Update()
    {
        if (GameControl.instance.gameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
