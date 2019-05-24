using UnityEngine;
using System.Collections;

public class OrbHolder : MonoBehaviour {
	public GameObject mashroomboy;
	public Mashroomboy mashroomboyScript;
	public GameObject[] diceArray; 
	public Texture[] textureArray;
	// Use this for initialization
	void Start () {
		mashroomboy = GameObject.FindGameObjectWithTag ("Mashroomboy");
		mashroomboyScript = mashroomboy.GetComponent<Mashroomboy> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void  OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player")) {
			mashroomboyScript.passcodeTaken=true;
			float random = Random.Range(0f, 5f);
			int arrayIndex = Mathf.RoundToInt(random);
			//Debug.Log(arrayIndex);
			GameObject newObject;
			newObject = (GameObject) Instantiate(diceArray[arrayIndex], transform.position + new Vector3(0,1,0) ,diceArray[arrayIndex].transform.rotation);
			newObject.renderer.material.mainTexture = textureArray[arrayIndex];
			mashroomboyScript.correctPasscode=arrayIndex;
			Destroy(gameObject);
		}
	}
}
