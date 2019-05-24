#pragma strict

var  fireEffect : GameObject;

function Start () {
	yield WaitForSeconds(5.0);
	Destroy(gameObject);
}



function OnCollisionEnter(other : Collision ) {
			//Instantiate(fireEffect, other.transform.position, Quaternion.identity);
			Destroy(gameObject);			
}
	
