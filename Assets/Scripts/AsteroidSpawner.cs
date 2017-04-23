using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

	// prefab of asteroid
	public GameObject asteroid;

	public int minX = -10;
	public int maxX = 10;
	public int minY = 20;
	public int maxY = 30;

	public float spawnTime = 2.0f;

	private int lessX = -17, moreX = 17;
	private int lessY = -8, moreY = 8;

	public Transform[] spawnPoints;
	public GameObject timer;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", spawnTime + 5, spawnTime );
	}
	
	void update() {
		if(timer.GetComponent<Timer>().time < 30) {
			InvokeRepeating("Spawn", spawnTime, spawnTime);
		} else if(timer.GetComponent<Timer>().time < 20) {
			InvokeRepeating("Spawn", spawnTime, spawnTime);
		} else if(timer.GetComponent<Timer>().time < 10) {
			InvokeRepeating("Spawn", spawnTime, spawnTime);
		}

	}

	void Spawn() {
		int x, y;
		do {
			x = Random.Range(minX, maxX);
			y = Random.Range(minY, maxY);
		} while((x > lessX && x < moreX ) || ( y < moreY && y > lessY ));

		Instantiate(asteroid, new Vector3(x, y, 0), new Quaternion());
	}
}
