using UnityEngine;
using System.Collections;

public class GestureEffectTutorial : GestureEffects {


	public AudioClip swipe_left;
	public AudioClip swipe_right;
	public AudioClip walk;
	public AudioClip walk_back;
	public AudioClip try_again;

	public bool tutrialStarted =false;
	public bool onSwipeLeft=false;
	public bool onSwipeRight=false;
	public bool onPush=false;
	public bool onWalk=false;
	public bool onWalkBack=false;


	public GameObject bullet;
	private float bulletSpeed = 20f;

	private FinishTutorial finishTutorial;
	private TeacherSoundScript teacherSoundScript;
	void Update(){
		//fnd the object that has the Gesture effect script
		GameObject liveGamebject = GameObject.FindGameObjectWithTag ("Teacher");
		//get the script that defines gesture effect
		if(liveGamebject != null)
			teacherSoundScript = liveGamebject.GetComponent<TeacherSoundScript> ();
		}
	          
						
	
	public override void SwipeLeftEffect(OVRPlayerController PlayerController,Transform root)
	{
		//Debug.Log ("In SwipeLeftEffect");
		root.transform.Rotate(0,30,0);
		PlayerController.RotateCamerasFromGestrure(30);
		if (tutrialStarted && onSwipeLeft) {
			Debug.Log ("SwapLeft Completed");
			onSwipeLeft=false;
			onSwipeRight = true;
			if(teacherSoundScript != null)
				teacherSoundScript.PlaySwipeRight();
		}
				
	}

	public override void SwipeRightEffect(OVRPlayerController PlayerController,Transform root)
	{
		//Debug.Log ("In SwipeRightEffect");
		root.transform.Rotate(0,-30,0);
		PlayerController.RotateCamerasFromGestrure(-30);
		if (tutrialStarted && onSwipeRight) {
			Debug.Log ("SwapRight Completed");
			onSwipeRight =false;
			onPush=true;
			if(teacherSoundScript != null)
				teacherSoundScript.PlayPush();
		}
	}
	public override void PushEffect()
	{
		Debug.Log ("In PushEffect");
		Camera cam = Camera.main;
		Debug.Log (cam.transform.ToString ());
		GameObject thebullet = (GameObject)Instantiate(bullet, cam.transform.position + cam.transform.forward, cam.transform.rotation);
		thebullet.rigidbody.AddForce( cam.transform.forward * bulletSpeed, ForceMode.Impulse);
		if (tutrialStarted && onPush) {
			Debug.Log ("Push Completed");
			onPush=false;
			onWalk=true;
			if(teacherSoundScript != null)
				teacherSoundScript.PlayWalk();
		}
	}
	public override void WalkEffect(CharacterController Controller, Vector3 speed)
	{
		//Debug.Log ("In Walk");
		Controller.Move(speed * Time.deltaTime);
		if (tutrialStarted && onWalk) {
			Debug.Log ("Walk Completed");
			onWalk=false;
			onWalkBack=true;
			if(teacherSoundScript != null)
				teacherSoundScript.PlayWalkBack();
		}
	}
	public override void WalkBackEffect(CharacterController Controller, Vector3 speed)
	{
		//Debug.Log ("In Walk");
		Controller.Move(speed * Time.deltaTime);
		if (tutrialStarted && onWalkBack) {
			Debug.Log ("Walk Completed");
			//fnd the object 
			GameObject liveGamebject = GameObject.FindGameObjectWithTag ("Teacher");
			//get the script that defines gesture effect
			if(liveGamebject != null){
				finishTutorial = liveGamebject.GetComponent<FinishTutorial> ();
				if(finishTutorial != null)
					finishTutorial.tutorialFinishes=true;
			}
		}
	}

}
