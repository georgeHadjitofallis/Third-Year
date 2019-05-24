using UnityEngine;
using System.Collections;

public class FinishTutorial : MonoBehaviour {

	public bool tutorialFinishes =false;
	public Transform finish_tutorial;
	// Update is called once per frame
	void Update () {
		if(tutorialFinishes)
		{
			Instantiate (finish_tutorial, this.transform.position, this.transform.rotation);
			Destroy(gameObject);
		}
	}
}
