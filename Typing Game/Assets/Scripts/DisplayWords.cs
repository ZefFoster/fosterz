using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWords : MonoBehaviour {

	public Text text;
	public float fallSpeed = 1f;

    //public AudioSource Ding;

    //public void PlayDing()
    //{
    //    Ding.Play();
   // }


    public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
	}

	public void RemoveWord ()
	{
		Destroy(gameObject);
       // PlayDing();
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
	}

}
