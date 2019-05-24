#pragma strict
var  intro :AudioClip;
var  tutorialStart : AudioClip;
var  touchTheOrb : AudioClip;
	
function Start () {
	audio.PlayOneShot (intro, 0.7f);
	yield WaitForSeconds(intro.length);
	audio.PlayOneShot (tutorialStart,0.7f);
	yield WaitForSeconds(tutorialStart.length);
	audio.PlayOneShot (touchTheOrb, 0.7f);
}
