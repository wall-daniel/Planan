using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour {

	public float speed = 25;
	public Rigidbody2D rb2d;
	public GameObject explosion;
	public GameObject player;

	private Transform originalTransform;
	private Vector3 vector3;
	private Vector3 oldVec;
	// Use this for initialization
	void Start () {
		originalTransform = transform.GetComponent<Transform>();

		int x, y;
		do{
			x = Random.Range(-30, 30);
			y = Random.Range(-20,20);
		} while((x > 17 || x < -17) && (y < -8 || y > 8));
		vector3 = new Vector3(x, y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, vector3, step);

		if(oldVec == transform.position) {
			Destroy(gameObject);
		}


		oldVec = transform.position;
	}

	public void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag("Planet")) {
			GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(expl, 2);
			Destroy(gameObject);
		}
		if(other.gameObject.name == "Player Sprite") {
			Time.timeScale = 0.4f;
			toGameOver();
			// Destroy(gameObject);
			// GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity);
			// Destroy(expl, 2);
		}
	}
	public void toGameOver() {
        SceneManager.LoadScene("GameOver");
    }
}
