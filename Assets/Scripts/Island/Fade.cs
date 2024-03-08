using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
	[SerializeField] private Animator anim;
	public int levelToLoad;

	//public Vector3 position;
	
	public void FadeToLevel()
	{
		anim.SetTrigger("fade");
	}

	public void OnFadeComplete(){
		SceneManager.LoadScene(levelToLoad);
	}
}
