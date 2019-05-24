using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {
	GameObject playerObject;
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
		if(health<=0){
			Destroy(gameObject);
		}
		if (Vector3.Distance (playerObject.transform.position, transform.position) < 5) {

			RotateToPlayer();
			float distance = Vector3.Distance (playerObject.transform.position, transform.position)/10;
			//if(distance > 0.4 )
			//	distance=1;
			//else
			//	distance = 0f;
			anim.SetBool("attack",true);
			anim.SetFloat("distance",distance);

		}
		else{
			anim.SetBool("attack",false);
		}
		
	}
	void  OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player") || collision.gameObject.tag == "Bullet") {
			health-=50;
		}
		
	}

	void RotateToPlayer(){
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerObject.transform.position - transform.position), 3*Time.deltaTime); 
	}
}
