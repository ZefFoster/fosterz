using UnityEngine;
using UnityEditor;
using System.IO;

public class ScoreInput : MonoBehaviour
{
    public void CreateText()
    {
        string path = Application.dataPath + "/Log.txt";
        if (!File.Exists(path)){
            File.WriteAllText(path, "Login log \n\n");
        }

        
        string content = Score2.OverallScore.ToString();
        File.AppendAllText(path, content);
        File.AppendText("\n");
    }

}