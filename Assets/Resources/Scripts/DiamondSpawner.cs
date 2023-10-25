using UnityEngine;
using System.Collections;

public class DiamondSpawner : MonoBehaviour {

	public GameObject[] prefabs;

	// Use this for initialization
	void Start () {
		
		// infinite diamond spawning function, asynchronous
		StartCoroutine(SpawnDiamonds());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnDiamonds() {
		while (true) {

			// number of diamonds we could spawn vertically
			int diamondsThisRow = Random.Range(1, 4);

			// instantiate all diamonds in this row separated by some random amount of space
			for (int i = 0; i < diamondsThisRow; i++) {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);
			}

			// pause blank to blank seconds until the next diamond spawns
			yield return new WaitForSeconds(Random.Range(5, 15));
		}
	}
}
