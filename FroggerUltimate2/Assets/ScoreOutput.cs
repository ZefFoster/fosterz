using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using static System.Convert;

public class ScoreOutput : MonoBehaviour
{
    public static string score1;
    public static string score2;
    public static string score3;

    public Text highScore1;
    public Text highScore2;
    public Text highScore3;

    string readPath;

    public List<string> stringList = new List<string>();
    //public List<int> intList = new List<int>();

    void Start()
    {
        
        readPath = Application.dataPath + "/Log.txt";
        ReadFile(readPath);


        /*void sortScores()
        {
            if (stringList[1] > stringList[2] && stringList[1] > stringList[3])
            {
                score1 = stringList[1];
            }
            if (stringList[2] > stringList[1] && stringList[2] > stringList[3])
            {
                score1 = stringList[2];
            }
            if (stringList[3] > stringList[2] && stringList[3] > stringList[1])
            {
                score1 = stringList[3];
            }
            if (stringList[1] > stringList[2] && stringList[1] < stringList[3])
            {
                score2 = stringList[1];
            }
            if (stringList[2] > stringList[1] && stringList[2] < stringList[3])
            {
                score2 = stringList[2];
            }
            if (stringList[3] > stringList[2] && stringList[3] < stringList[1])
            {
                score2 = stringList[3];
            }
            if (stringList[1] < stringList[2] && stringList[1] < stringList[3])
            {
                score3 = stringList[1];
            }
            if (stringList[2] < stringList[1] && stringList[2] < stringList[3])
            {
                score3 = stringList[2];
            }
            if (stringList[3] < stringList[2] && stringList[3] < stringList[1])
            {
                score3 = stringList[3];
            }


        }*/
       // string number1 = stringList[1];
       // string number3 = stringList[2];
        //string number2 = stringList[3];
        //intList[1] = int.Parse(number1);
        //intList[2] = int.Parse(number2);
        //intList[3] = int.Parse(number3);

        /*if (intList[1] > intList[2] && intList[1] > intList[3])
        {
            score1 = intList[1];
        }
        if (intList[2] > intList[1] && intList[2] > intList[3])
        {
            score1 = intList[2];
        }
        if (intList[3] > intList[2] && intList[3] > intList[1])
        {
            score1 = intList[3];
        }
        if (intList[1] > intList[2] && intList[1] < intList[3])
        {
            score2 = intList[1];
        }
        if (intList[2] > intList[1] && intList[2] < intList[3])
        {
            score2 = intList[2];
        }
        if (intList[3] > intList[2] && intList[3] < intList[1])
        {
            score2 = intList[3];
        }
        if (intList[1] < intList[2] && intList[1] < intList[3])
        {
            score3 = intList[1];
        }
        if (intList[2] < intList[1] && intList[2] < intList[3])
        {
            score3 = intList[2];
        }
        if (intList[3] < intList[2] && intList[3] < intList[1])
        {
            score3 = intList[3];
        }*/

        

        score1 = stringList[1];
        score2 = stringList[2];
        score3 = stringList[3];
        //Debug.Log("hi");
        highScore1.text = score1.ToString();
        highScore2.text = score2.ToString();
        highScore3.text = score3.ToString();
    }

    void ReadFile(string readPath)
    {
        StreamReader sReader = new StreamReader(readPath);

        while (!sReader.EndOfStream)
        {
            string line = sReader.ReadLine();
            stringList.Add(line);
        }
        sReader.Close();
    }
}
