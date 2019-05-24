using UnityEngine;
using System.Collections;

public class AlienBehave : MonoBehaviour {
	public bool inFight = false;
	public Transform target;
	public float minFightDistance = 5.0f;
	public float rotationSpeed = 5.0f;
	public AudioClip doubleShooting;
	public Animator anim;
	public bool shooting=false; 
	public float health = 100;
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update  () {
		if(health <=0 ){
			Destroy(gameObject);
		}
		inFight = IsInFight (); 
		if (inFight) {
			anim.SetBool ("InBattle", true);
			anim.SetBool("Shoot",true);
			Shoot ();
		}
		else{
			anim.SetBool("Shoot",false);
			anim.SetBool ("InBattle", false);
		}
	}
	void  OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player") || collision.gameObject.CompareTag ("Bullet")) {
			health-=50;
		}
		
	}
	void RotateToTarget(){
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), rotationSpeed*Time.deltaTime); 
	}
	bool IsInFight (){
		if (target) {
			float dist = Vector3.Distance (target.position, transform.position);
			//Debug.Log ("Distance to other: " + dist);
			if (dist <= minFightDistance) {
				return true;
			}
			else {
				return false;
			}
		}
		else {
			return false;	
		}
	}
	void Shoot(){
		//Debug.Log("IN Fight");
		if(!audio.isPlaying){
			audio.Play();
		}
		RotateToTarget();



	}
}
