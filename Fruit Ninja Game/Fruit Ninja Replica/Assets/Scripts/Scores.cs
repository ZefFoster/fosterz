using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using static System.Convert;

public class Scores : MonoBehaviour
{
    
    public InputField name;
    public Text fText;
    public Text scoreText1;
    public Text scoreText2;
    public Text scoreText3;
    public Text scoreText4;
    public List<string> stringList = new List<string>();

    public void CreateText()
    {
        fText.text = "Your name is " + name.text;
    }

   
    public void WriteScores()
    {
        string path = Application.dataPath + "/Log.txt";
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "\n");
        }

        File.AppendAllText(path, name.text +" " +ScoreAgain.scoreInt);
        File.AppendAllText(path, "\n");
    }

    public void ReadScores()
    {
        string path = Application.dataPath + "/Log.txt";

        StreamReader sReader = new StreamReader(path);

        while (!sReader.EndOfStream)
        {
            string line = sReader.ReadLine();
            stringList.Add(line);
        }
        sReader.Close();
        Debug.Log(stringList[1]);

        scoreText1.text = stringList[0];
        scoreText2.text = stringList[1];
        scoreText3.text = stringList[2];
        scoreText4.text = stringList[3];

    }

    void Start()
    {
        ReadScores();
    }
}
