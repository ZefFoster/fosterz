using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Text speedText;

    void Start()
    {
        speedText.text = GameController.speed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
