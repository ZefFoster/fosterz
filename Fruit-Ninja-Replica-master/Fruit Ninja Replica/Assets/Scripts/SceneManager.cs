using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public void changeMenuScene()
    {
        Application.LoadLevel("Main");
    }
    public void changeScoreScene()
    {
        Application.LoadLevel("Scores");
    }
}
