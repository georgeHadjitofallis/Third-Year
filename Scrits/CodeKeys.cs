using UnityEngine;
using System.Collections;

public class CodeKeys : MonoBehaviour {
	public bool correctCode =false;


	void  OnCollisionEnter(Collision collision){
		//Debug.Log (collision.gameObject.tag.ToString ());
		if (collision.gameObject.CompareTag ("Hand") || collision.gameObject.CompareTag ("Player")) {
			if(correctCode){
				Debug.Log("code correct");
				GameObject blockingRock = GameObject.FindGameObjectWithTag("BlockingRock");
				blockingRock.GetComponent<BlockingRockScirpt>().remove = true;
				foreach (GameObject key in GameObject.FindGameObjectsWithTag("Key")){
					key.GetComponent<RemoveCodeKey>().remove = true;
				}

				//for(int index = 0; index< keyArray.Length; index++){
				//	newObject = (GameObject)Instantiate(keyArray[index], keyArray[index].transform.position, keyArray[index].transform.rotation);
				//	newObject.renderer.material.mainTexture = textureArray[index];
				//}
				GetComponent<RemoveCodeKey>().remove = true;
			}
			else{
				Debug.Log("Wrong code");
			}
			
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
