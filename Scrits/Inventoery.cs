using UnityEngine;
using System;//.Collections;



public class Inventoery : MonoBehaviour {
	public class bagnItem{
		public string item;
		public int itemNumber;
	}
	public bagnItem[] playersBack;
	// Use this for initialization
	void Start () {
		playersBack = new bagnItem[20];
		for(int i = 0; i< playersBack.Length;i++){
			playersBack[i] = new bagnItem();
		}
		
	}
	void Update () {
		for(int i = 0; i< playersBack.Length;i++){
			Debug.Log(playersBack[i].item);
		}
	}
	public void AddItemInBack(string item, int nmberOftems){
		for(int index=0; index<playersBack.Length;index++){
			if(playersBack[index] != null){
				if(String.Compare(playersBack[index].item,item) ==0){
					playersBack[index].itemNumber+=nmberOftems;
					Debug.Log(item + " 1+" + nmberOftems);
				}
				else{
					if(playersBack[index].itemNumber <= 0){
						playersBack[index].item = item;
						playersBack[index].itemNumber = nmberOftems;
						Debug.Log(item + " 2+" + nmberOftems);
					}
				}
			}
			else{
				if (index <playersBack.Length){
					playersBack[index].item = item;
					playersBack[index].itemNumber = nmberOftems;
					Debug.Log(item + " 3+" + nmberOftems);
				}
			}
		}
	}

	public void DeleteItemInBack(string item, int nmberOftems){
		for(int index=0; index<playersBack.Length;index++){
			if(playersBack[index] != null){
				if(String.Compare(playersBack[index].item,item) == 0){
					playersBack[index].itemNumber-= nmberOftems;
					Debug.Log("item deleted");
				}
			}
		}
	}
	public bool FindItem(string item){
		for(int index=0; index<playersBack.Length;index++){
			if(playersBack[index] != null){
				if(String.Compare(playersBack[index].item,item) == 0){
					if(playersBack[index].itemNumber>0){
						return true;
					}
				}
			}
		}
		return false;
	}
}
