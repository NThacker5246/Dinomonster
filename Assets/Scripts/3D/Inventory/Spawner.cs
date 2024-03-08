using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject wood;
	public float MoveX;
	public float MoveY;
	public float MoveZ;
	public float timeToSpawnWood;

	private void Start(){
		StartCoroutine("SummonWood");
	}

	IEnumerator SummonWood(){
		while(true){
			Instantiate(wood, transform.position + new Vector3(Random.Range(0, MoveX), Random.Range(0, MoveY), Random.Range(0, MoveZ)), Quaternion.identity);
			Debug.Log("Cor");
			yield return new WaitForSeconds(timeToSpawnWood);
		}
	}
}
