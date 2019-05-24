using UnityEngine;
using System.Collections;

public class HumanPrisoner : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void  OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player") || collision.gameObject.tag == "Bullet") {
			anim.SetBool("MiaIsFree",true);
			
		}
		
	}
}
