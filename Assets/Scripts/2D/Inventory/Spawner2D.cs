using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2D : MonoBehaviour
{
	public GameObject wood;
	public float MoveX;
	public float MoveY;
	public float timeToSpawnWood;

	private void Start(){
		StartCoroutine("SummonWood");
	}

	IEnumerator SummonWood(){
		while(true){
			Instantiate(wood, transform.position + new Vector3(Random.Range(0, MoveX), Random.Range(0, MoveY), 0f), Quaternion.identity);
			Debug.Log("Cor");
			yield return new WaitForSeconds(timeToSpawnWood);
		}
	}
}
