using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using static System.Convert;

public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public float startForce = 15f;
	Rigidbody2D rb;
    

    

    void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);

        if (ScoreAgain.fails == 3)
        {
            Application.LoadLevel("Scores");
        }
        if (ScoreAgain.scoreInt == 20)
        {
            Application.LoadLevel("Scores");
        }

	}

    

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade")
		{
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
			Destroy(slicedFruit, 3f);
			Destroy(gameObject);
            ScoreAgain.scoreInt = ScoreAgain.scoreInt + 1;
            
        }
        if (col.tag == "box")
        {
            ScoreAgain.fails = ScoreAgain.fails + 1;
            Debug.Log("Fail");
        }

	}

}
