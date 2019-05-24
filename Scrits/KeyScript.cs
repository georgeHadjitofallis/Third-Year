using UnityEngine;
using System.Collections;

public class KeyScript : MonoBehaviour {
	GameObject prison;

	void  OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player")) {
			prison = GameObject.FindGameObjectWithTag("Prison2");
			if(prison != null){
				prison.GetComponent<PrisonBreak>().locked=false;
			}
			Destroy(gameObject);
		}

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
