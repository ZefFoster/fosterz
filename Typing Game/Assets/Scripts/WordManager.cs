using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

    public AudioSource Ding;


    //public GUIText scoreText;
    //public int score;

    //void Start()
    //{
    //    score = 0;
    //    UpdateScore();
    //}


   // void UpdateScore()
    //{
    //    scoreText.text = "Score: " + score;
    //}

    public void PlayDing()
    {
        Ding.Play();
    }

    public void AddWord ()
	{
		Word word = new Word(GenerateWords.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);

		words.Add(word);
	}

	public void TypeLetter (char letter)
	{ 
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
			}
		} else
		{
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

        

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
            PlayDing();
            ScoreValue.scoreValue += 1;
        }


	}

    //public AudioClip clip;
    //public AudioSource source;

    //void ding()
   // {
     //   source.clip = clip;
   // }


}
