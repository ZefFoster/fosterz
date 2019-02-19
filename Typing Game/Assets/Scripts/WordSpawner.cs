using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject wordPrefab;
	public Transform wordCanvas;

	public DisplayWords SpawnWord ()
	{
		Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);

		GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
        DisplayWords displayWords = wordObj.GetComponent<DisplayWords>();

		return displayWords;
	}

}
