using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingTable : MonoBehaviour
{
	public bool IsInCollider;
	public Animator anim;

	private void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			IsInCollider = true;
		}
	}

	private void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			IsInCollider = false;
		}
	}

	private void Update(){
		if(IsInCollider){
			if(Input.GetKeyDown(KeyCode.E)){
				anim.SetBool("Craft", true);
			}
		}
	}
}
