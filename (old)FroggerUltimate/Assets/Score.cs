using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;
    public AudioSource Ding;
    public Text scoreText;

	void Start ()
	{
		scoreText.text = CurrentScore.ToString();
	}

    public void PlayDing()
    {
        Ding.Play();
    }
}
