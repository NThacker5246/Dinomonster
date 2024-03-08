using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
	public Transform player; // Так быстрее
	public int kZ;
	void Update(){
		float ro = player.gameObject.GetComponent<PlayerC2>().rotationY;
		transform.rotation = player.rotation;
		transform.position = Quaternion.Euler(new Vector3(0f, ro, 0f)) * new Vector3(player.position.x, transform.position.y, player.position.z + kZ); //Так, по x и z, чтобы удобнее было, а сверх только y	
	}
}
