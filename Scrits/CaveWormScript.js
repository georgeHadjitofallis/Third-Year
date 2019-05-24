#pragma strict

var playerTransform : Transform;
var wormSpeed : float = 3.0;
var orbPosition : GameObject ;
var breathFire:GameObject;
var playerObject : GameObject;
var orbHolder :GameObject;
var forward : Vector3 ;
var health : float = 30;
function OnCollisionEnter(collision : Collision )
 {
		//Debug.Log("Collis");
		if(collision.gameObject.tag == "Hand" || collision.gameObject.tag == "Bullet")
		{
			health -= 10;
			Debug.Log("Health: " + health);
            			
		}//if
		else{
			RotateRandomly();
		}
}
function Update () {
	playerObject = GameObject.FindWithTag("Player");
	if(playerObject != null){
	   //Debug.Log("PLayer fund");
		playerTransform= playerObject.transform;
		if(checkForFight()){
			RotateToPlayer();	
			Debug.Log("Ds"+Vector3.Distance(playerTransform.position, transform.position));		
			if(Vector3.Distance(playerTransform.position, transform.position) >= 3)
			{
				Move();		
				Wait();
				//Debug.Log("Attack");
				var new_object = Instantiate(breathFire, this.transform.position , this.transform.rotation);
				Wait();
			}
		}
		/*else{
			Debug.Log("Rotate RAndomly");
			RotateRandomly();	
			Move();		
			Debug.Log("Mved");
			Wait();
			Debug.Log("Wait");
		}*/
		if(health <=0){
			Instantiate(orbHolder, orbPosition.transform.position , orbHolder.transform.rotation);
//			Destroy(orbPosition);
			Destroy(gameObject);
		}
		
			
	}
}
function RotateRandomly(){
	var targetRotatn = Vector3.left;
	transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetRotatn - transform.position), wormSpeed*Time.deltaTime);
}
function Wait(){
	yield WaitForSeconds(3);
}
function Move( ){
	transform.position += transform.forward * wormSpeed * Time.deltaTime;
}
function RotateToPlayer(){
	transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerTransform.position - transform.position), wormSpeed*Time.deltaTime); 
} 
function checkForFight() {
	var dist = Vector3.Distance(playerTransform.position, transform.position);
	if (dist<=5){
		return true;
	}
	else{
		return false;
	}
}
