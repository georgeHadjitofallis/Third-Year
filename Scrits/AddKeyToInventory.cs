using UnityEngine;
using System.Collections;

public class AddKeyToInventory : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void  OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player") || collision.gameObject.tag == "Bullet") {
			GameObject pl= GameObject.FindGameObjectWithTag("Player");
			pl.GetComponent<Inventoery>().AddItemInBack("key", 1);
			Destroy(gameObject);
		}
		
	}
}
