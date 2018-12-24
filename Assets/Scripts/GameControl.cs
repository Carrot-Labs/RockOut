using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static GameControl instance;

    public GameObject gameOverText;
    public Text scoreText;
    public Text healthText;

    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private float score = 0;
    private float health = 0;

	void Awake ()
    {
	    if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this.gameObject);
        }
	}
	
	void Update ()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void PlayerDurabilityAdjust(float value)
    {
        if (gameOver)
            return;

        health = health + value;
        healthText.text = "Health : " + health.ToString();
    }

    public void PlayerScored(float value)
    {
        if (gameOver)
            return;

        score = score + value;
        scoreText.text = "Score : " + score.ToString();
    }

    public void PlayerDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
