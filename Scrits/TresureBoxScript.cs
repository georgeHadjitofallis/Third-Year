using UnityEngine;
using System.Collections;

public class TresureBoxScript : MonoBehaviour {
	public bool isLocked =false;//todo change
	public Animator anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void  OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player")) {
			if(!isLocked){
				anim = GetComponent<Animator>();
				anim.SetBool("locked",false);
			}
		}
		
	}
}
