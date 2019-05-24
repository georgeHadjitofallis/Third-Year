using UnityEngine;
using System.Collections;

public class Mashroomboy : MonoBehaviour {
	public GameObject[] keyArray;
	public Texture[] textureArray;
	public bool passcodeTaken = false;
	public int	correctPasscode;
	private GameObject newObject; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  OnCollisionEnter(Collision collision){
		Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player")) {
			if(passcodeTaken){
				Debug.Log("code taken");
				for(int index = 0; index< keyArray.Length; index++){
					newObject = (GameObject)Instantiate(keyArray[index], keyArray[index].transform.position, keyArray[index].transform.rotation);
					newObject.renderer.material.mainTexture = textureArray[index];
					if(index == correctPasscode){
						newObject.GetComponent<CodeKeys>().correctCode =true;
					}
				}
				Destroy(gameObject);
			}
			else{
				Debug.Log("Need code");
			}

		}
	}
	
}
