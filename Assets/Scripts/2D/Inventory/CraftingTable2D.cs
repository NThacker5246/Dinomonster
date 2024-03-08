using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingTable2D : MonoBehaviour
{
	public bool IsInCollider;
	public Animator anim;

	private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			IsInCollider = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other){
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
