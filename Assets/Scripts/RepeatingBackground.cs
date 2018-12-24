using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    public float groundHorizontalLength;
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -groundHorizontalLength)
        {
            RepositionBackground();
        }
	}

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(0, groundHorizontalLength * 2);
        transform.position = (Vector2)(transform.position) + groundOffset;
    }
}
