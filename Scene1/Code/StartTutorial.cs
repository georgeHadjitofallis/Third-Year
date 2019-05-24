using UnityEngine;
using System.Collections;

public class StartTutorial : MonoBehaviour {
	public GameObject firePositionObject;
	private GestureEffectTutorial gestureEffectScript;
	public float speed = 10f;
	public Transform firePrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, speed * Time.deltaTime);
		
	}
	void OnCollisionEnter(Collision other){
		//Debug.Log("Tach");

		Vector3 tutorePosition = transform.position;
		tutorePosition.y -= 1f;
		Instantiate (firePrefab, firePositionObject.transform.position, firePositionObject.transform.rotation);
		Destroy (firePositionObject);
		//fnd the object that has the Gesture effect script
		GameObject liveGamebject = GameObject.FindGameObjectWithTag ("Player");
		//get the script that defines gesture effect
		gestureEffectScript = liveGamebject.GetComponent<GestureEffectTutorial> ();
		//change the appropriate components to start the tutorial 
		gestureEffectScript.tutrialStarted = true;
		gestureEffectScript.onSwipeLeft = true;
		//destroy this object
		Destroy (gameObject);
	}
}
