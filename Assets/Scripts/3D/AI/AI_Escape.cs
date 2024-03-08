using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Escape : MonoBehaviour
{
	public float seeDist;
	public float angle;
	public float speed;
	private float rotationY;
	private Rigidbody rb;
	public bool isRotated = true;
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();	
	}

	// Update is called once per frame
	void Update()
	{
		if(isRotated){
			Vector3 forwards = new Vector3(0, 0, 1*speed);
			Vector3 movement = forwards * Time.deltaTime;
			movement = Quaternion.Euler(0f, rotationY, 0f) * movement;
			transform.position += movement;
		} else {
			rotationY += angle;
			rotationY = rotationY % 360;
			transform.localRotation = Quaternion.Euler(0f, rotationY, 0f);
		}
	}

	void OnTriggerStay(Collider other){
		if (other.tag != "Player"){
			isRotated = false;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.tag != "Player"){
			isRotated = true;
		}
	}
}
