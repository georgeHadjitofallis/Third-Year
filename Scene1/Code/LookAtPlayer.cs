using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {
	private Transform myTransform;
	private Transform playerTranform;
	public float rotationSpeed = 5f;
	void Awake()
	{
		//myTransform = this.transform;
	}
	// Use this for initialization
	void Start () {
		playerTranform =GameObject.FindWithTag("Player").transform; 
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(playerTranform.position - this.transform.position), rotationSpeed*Time.deltaTime);

	}
}
