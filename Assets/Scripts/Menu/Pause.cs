using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
	public Animator anim;

	public void Stop(){
		gameObject.SetActive(true);
		Time.timeScale = 0;
	}

	public void Run(){
		Time.timeScale = 1;
		gameObject.SetActive(false);
	}
}