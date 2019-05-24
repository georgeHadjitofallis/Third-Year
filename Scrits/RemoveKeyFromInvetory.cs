using UnityEngine;
using System.Collections;

public class RemoveKeyFromInvetory : MonoBehaviour {

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
			Inventoery plInventory = pl.GetComponent<Inventoery>();
			if(plInventory.FindItem("key")){
				plInventory.DeleteItemInBack("key", 1);
				Destroy(gameObject);
			}

		}
		
	}
}
