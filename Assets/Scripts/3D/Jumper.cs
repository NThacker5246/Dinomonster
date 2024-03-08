using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
	public PlayerC2 player;

	private void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			player.isGrounded = true;
		}
	}

	private void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			player.isGrounded = false;
		}
	}
}
