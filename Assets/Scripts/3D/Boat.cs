using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
	public float g = 1f;
	public float V;
	public float p;
	public float vp;
	public float k;
	public bool isInBoat;
	public bool isInCollider;
	public PlayerC2 player;
	public float boatSpeed;
	private Rigidbody rb;

	private void Start(){
		rb = GetComponent<Rigidbody>();
	}

	private void FixedUpdate(){
		if(isInCollider && Input.GetKeyDown(KeyCode.LeftShift)){
			isInBoat = true;
			player.IsStatic = true;
		}
		if(isInBoat && Input.GetKeyDown(KeyCode.LeftShift)){
			isInBoat = false;
			player.IsStatic = false;
		}

		if(isInBoat){
			float horizontal = Input.GetAxis("Horizontal") * boatSpeed;
			float vertical = Input.GetAxis("Vertical") * boatSpeed;
			Vector3 movement = new Vector3(horizontal, 0f, vertical);
			rb.AddForce(movement);
		}

		float Fa = g*p*V;
		if(vp <= -5){
			vp = V; 
		}
		Vector3 ph = new Vector3(0f, Fa, 0f);
		rb.AddForce(ph);
		vp = vp - k;
	}

	public void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			isInCollider = true;
		}
	}


	public void OnTriggerExit(Collider other){
		if(other.tag == "Player"){
			isInCollider = false;
		}
	}
}
