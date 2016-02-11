using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] tetrominoes;

	// Use this for initialization
	void Start () {
		spawnNext ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void spawnNext() {
		int i = Random.Range (0, tetrominoes.Length);

		Instantiate (tetrominoes [i], transform.position, Quaternion.identity);
	}
}
