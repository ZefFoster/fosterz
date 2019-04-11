using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public static int OverallScore = 0;
  
    public Text scoreTextOA;
   
    void Start ()
    {
        scoreTextOA.text = OverallScore.ToString();

    }

    
}
