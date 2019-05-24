using UnityEngine;
using System.Collections;

public class BlockingRockScirpt : MonoBehaviour {
	public bool remove =false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(remove){
			Destroy(gameObject);
		}
	
	}
}
