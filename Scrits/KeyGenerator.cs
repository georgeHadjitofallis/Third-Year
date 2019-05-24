using UnityEngine;
using System.Collections;

public class KeyGenerator : MonoBehaviour {
	public GameObject[] zombieObjects;
	public GameObject key;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		zombieObjects = GameObject.FindGameObjectsWithTag("Zombie");
		if(zombieObjects == null || zombieObjects.Length == 0){
			Instantiate(key, key.transform.position, key.transform.rotation);
			Destroy (gameObject);
		}

	}
}
