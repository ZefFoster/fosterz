using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEnd : MonoBehaviour
{
    public Text scoreText;
    public Text nameText;

    void Start()
    {
        scoreText.text = ScoreKeeper.newScore.ToString();
        nameText.text = GameController.username;
    }

}
