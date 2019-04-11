using UnityEngine;

public class CarSpawner : MonoBehaviour {

	public float spawnDelay = .3f;

	public GameObject car;

	public Transform[] spawnPoints;
    public static float carDelay = 0f;

    void updateDelay()
    {
        carDelay += .3f;
    }

	float nextTimeToSpawn = carDelay;

	void Update ()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		Instantiate(car, spawnPoint.position, spawnPoint.rotation);
	}

}
