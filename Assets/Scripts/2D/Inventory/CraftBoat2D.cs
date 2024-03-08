using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftBoat2D : MonoBehaviour
{
	public Inventory2D inventory;
	public Spawn2D[] items;
	public int wood;
	public GameObject boat;

	public void Start(){
		items = new Spawn2D[20];
	}

	public void GetItems(){
		int i = 0;
		foreach(GameObject slot in inventory.slots){
			Transform slotT = slot.GetComponent<Transform>();
			foreach(Transform child in slotT){
				Spawn2D item = child.gameObject.GetComponent<Spawn2D>();
				items[i] = item;
				i += 1;
			}
		}
	}

	public void Craft(){
		int woodCount = 0;
		int[] woods = new int[20];
		int j = 0;
		foreach(Spawn2D item in items){
			if(item != null){
				int curId = item.id;
				if (curId == 1){ //id = 1 - это дерево
					woods[woodCount] = j;
					woodCount += 1;
				}
			}
			j += 1;
		}
		
		int woodToNeedDelete;

		if(woodCount >= wood){
			woodToNeedDelete = wood;
			for(int i = 0; i < woodToNeedDelete; i++){
				int deleteId = woods[i];
				Debug.Log(deleteId);
				Destroy(items[deleteId].gameObject);
			}
			Instantiate(boat, inventory.gameObject.GetComponent<Transform>().position, Quaternion.identity);
		} else {
			Debug.Log("Не хватает досок");
		}
	}

	public void Close(){
		GetComponent<Animator>().SetBool("Craft", false);
	}
}