using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour {

	public GameObject[] collectablesPrefabs;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.P)) {
			Instantiate (collectablesPrefabs [Random.Range (0, collectablesPrefabs.Length)], new Vector2 (Random.Range (-12, 12), Random.Range (-4.5f, 4.5f)), Quaternion.identity); 
		}
		
	}
}
