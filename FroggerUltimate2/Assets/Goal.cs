using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
        Score2.OverallScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //if (Score.CurrentScore == 1000)
       // {
        //    Application.LoadLevel("Win");
        //}
        
	}

}
