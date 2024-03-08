using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoSummon2D : MonoBehaviour
{
	public GameObject prefab;
	public Storage st;

	public void Summon(){
		Vector3 vec = new Vector3(transform.position.x, transform.position.y + 200, 0f);
		Instantiate(prefab, vec, Quaternion.identity);
	}

	public void Update(){
		if (Input.GetKeyDown(KeyCode.C))
        {
        	if(st.Eggs > 0){
            	Summon();
            	st.Eggs = st.Eggs - 1;
        	} else {
        		Debug.Log("Нет яиц");
        	}
        }
	}
}
