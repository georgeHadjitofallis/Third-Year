using UnityEngine;
using System.Collections;

public class DinoScript : MonoBehaviour {
	GameObject playerObject;
	public GameObject key;
	Animator anim;
	bool attack =false;
	float health = 100;
	// Use this for initialization
	void Start () {
		playerObject=GameObject.FindGameObjectWithTag("Player");
		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(health <=0){
			anim.SetBool("idDead", true);
			Instantiate(key, transform.position, key.transform.rotation);
		}
		if (Vector3.Distance (playerObject.transform.position, transform.position) < 5) {
			
			RotateToPlayer();
			anim.SetBool("inFight",true);
			float distance = Vector3.Distance (playerObject.transform.position, transform.position);
			if(distance > 3){
				anim.SetFloat("walk",-0.1f);
			}
			else{
				anim.SetFloat("walk",0.8f);
			}

			
			
		}
		else{
			anim.SetBool("inFight",false);
		}
		
	}
	void RotateToPlayer(){
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation( transform.position - playerObject.transform.position), 3*Time.deltaTime); 
	}
	void  OnCollisionEnter(Collision collision){
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Bullet")) {
			health-=50;
		}
	}
}
