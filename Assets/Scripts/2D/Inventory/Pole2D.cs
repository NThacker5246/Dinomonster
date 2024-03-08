using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole2D : MonoBehaviour
{
	public Animator anim;
	public Transform Player;
	public GameObject Wheat;
	private Vector3 vec = new Vector3(0, 2, 0);
	public void Start(){
		anim.SetBool("Wheat", false);
	}

	private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			anim.SetBool("Wheat", true);
		}
	}
	private void OnTriggerExit2D(Collider2D other){
		if(other.tag == "Player"){
			anim.SetBool("Wheat", false);
		}
	}

	public void Sum(){
		Instantiate(Wheat, Player.position - vec, Quaternion.identity);
	}
}
