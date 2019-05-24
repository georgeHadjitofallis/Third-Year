﻿using UnityEngine;
using System.Collections;

public class PrisonBreak : MonoBehaviour {
	public bool locked = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void  OnCollisionEnter(Collision collision){
		//Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player")) {
			if(!locked){
				Destroy(gameObject);
			}
		}
		
	}
}