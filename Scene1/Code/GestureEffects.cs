using UnityEngine;
using System.Collections;

public abstract class GestureEffects : MonoBehaviour {

	public abstract void SwipeLeftEffect(OVRPlayerController PlayerController, Transform root);
	public abstract void SwipeRightEffect(OVRPlayerController PlayerController, Transform root);
	public abstract void PushEffect();
	public abstract void WalkEffect(CharacterController Controller, Vector3 speed);
	public abstract void WalkBackEffect(CharacterController Controller, Vector3 speed);

}
