using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;

   

    

    public static int lives = 3;
    public Text LivesText;

    public void Start()
    {
       LivesText.text = lives.ToString();
    }
   

    void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
            
            Debug.Log("WE LOST!");
			Score.CurrentScore = 0;
            lives = lives - 1;
            Debug.Log(lives);
            if (lives < 1)
            {

                Application.LoadLevel("Win");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
            //PlayHonk();
        }
	}
}
