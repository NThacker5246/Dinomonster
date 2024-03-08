using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Follow : MonoBehaviour
{
	public float speed;
	public Transform target;
	public float stoppingDistance;
	public float retreatDistance;
	public float seeDist;

	void Start(){
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	void Update()
	{
		float dist = Vector3.Distance(transform.position, target.position);
	
		
		//bool tow = Physics.Raycast(transform.position, Vector3.forward, seeDist);
		//if(tow == false){
		if(dist > stoppingDistance){
			transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
		} else if(dist < stoppingDistance && dist > retreatDistance){
			return;
		} else if(dist < retreatDistance){
			transform.position = Vector3.MoveTowards(transform.position, target.position, -speed);
		}
		/*} else {
			transform.eulerAngles = new Vector3(transform.rotation.x, transform.rotation.y + 10f, transform.rotation.z);
			return; 
		}*/
	} 
}
