#pragma strict
var teacherTransform : Transform;

function Start () {
 yield WaitForSeconds(1.0);
 Instantiate (teacherTransform, this.transform.position, this.transform.rotation);
 yield WaitForSeconds(1.5);
 Destroy(gameObject);
}
