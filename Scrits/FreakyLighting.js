#pragma strict

var secndsUntilOn : float;
var secondsUntilOff : float;
var lowerLimit : float =0.0;
var upperLimit: float =0.3;

function Start () {
	while(true){
		secndsUntilOn= Random.Range(lowerLimit, upperLimit);
		yield WaitForSeconds(secndsUntilOn);
		light.enabled=true;
		secondsUntilOff=Random.Range(lowerLimit, upperLimit);
		yield WaitForSeconds(secondsUntilOff);
		light.enabled=false;
	}
}