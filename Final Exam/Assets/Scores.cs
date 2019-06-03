using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Scores : MonoBehaviour
{
    public Text score;
    public Text score2;
    public Text score3;
    public Text score4;
    public Text score5;
    public List<string> stringList = new List<string>();


    void Start()
    {
        ReadScores();
        score.text = stringList[0].ToString();
        score2.text = stringList[1].ToString();
        score3.text = stringList[2].ToString();
        score4.text = stringList[3].ToString();
        score5.text = stringList[4].ToString();
    }

    public void ReadScores()
    {
        string path = Application.dataPath + "/scores.txt";

        StreamReader sReader = new StreamReader(path);

        while (!sReader.EndOfStream)
        {
            string line = sReader.ReadLine();
            stringList.Add(line);

        }
        sReader.Close();

        score.text = stringList[0];
        score2.text = stringList[1];
        score3.text = stringList[2];
        score4.text = stringList[3];
        score5.text = stringList[3];

    }
    public void WriteScores()
    {
        string path = Application.dataPath + "/scores.txt";
        File.AppendAllText(path, GameController.username + " " + ScoreKeeper.newScore);
        File.AppendAllText(path, "\n");
    }
}
