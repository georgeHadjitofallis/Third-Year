using UnityEngine;
using System.Collections;

public class TeacherSoundScript : MonoBehaviour {

	public AudioClip swipe_left;
	public AudioClip swipe_right;
	public AudioClip walk;
	public AudioClip walk_back;
	public AudioClip try_again;
	public AudioClip push;
	public AudioClip touch_gate;
	public void PlaySwipeLeft(){
		audio.PlayOneShot(swipe_left, 0.7F);
	}

	public void PlaySwipeRight () {
		audio.PlayOneShot(swipe_right, 0.7F);
	}
	public void PlayWalk () {
		audio.PlayOneShot(walk, 0.7F);
	}
	public void PlayWalkBack () {
		audio.PlayOneShot(walk_back, 0.7F);
	}
	public void TryAgain () {
		audio.PlayOneShot(try_again, 0.7F);
	}
	public void PlayPush () {
		audio.PlayOneShot(push, 0.7F);
	}

}
