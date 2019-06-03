using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameController : MonoBehaviour
{
    public string name;
    public InputField usernameField;
    public static string username;
    string path = Application.dataPath + "/scores.txt";
    public void SceneChange ()
    {
        Application.LoadLevel(name);
    }
    public void Destroy()
    {
        Destroy(GameObject.FindWithTag("rrr"));
    }
    public void debugger()
    {
        Debug.Log("Test Successful");
    }
    public void writeToFile()
    {
        username = usernameField.text.ToString();
        File.WriteAllText(path, username + " " + ScoreKeeper.newScore);
    }

    public static int speed;
    public void changeSpeed2()
    {
        speed = 2;
    }
    public void changeSpeed3()
    {
        speed = 3;
    }
    public void changeSpeed1()
    {
        speed = 1;
    }
    public void quit()
    {
        Application.Quit();
    }
}
