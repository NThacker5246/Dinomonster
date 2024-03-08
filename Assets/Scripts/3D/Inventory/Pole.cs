using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
	public Animator anim;
	public Transform Player;
	public GameObject Wheat;
	public Vector3 vec = new Vector3(0, 2, 0);
	public void Start(){
		anim.SetBool("Wheat", false);
	}

	private void OnTriggerEnter(){
		anim.SetBool("Wheat", true);
	}
	private void OnTriggerExit(){
		anim.SetBool("Wheat", false);
	}

	public void Sum(){
		Instantiate(Wheat, Player.position - vec, Quaternion.identity);
	}
}
