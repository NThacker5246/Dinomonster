using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
	public Island[] islands; //Список островов через public (Из других скриптов нужен доступ)
	public Storage storage;
	public Fade fade;
	public Fade fade2;
	public int hot;

	private void Start(){
		int j = 0;
		foreach(Island island in islands){
			island.isBoutght = storage.isBoughtIsland[j];
			j += 1;
		}
	}

	public void get(int i) {
		Island current = islands[i];
		Debug.Log(i);
		if (current.isBoutght == false){
			if (storage.Coins >= current.cost){
				current.isBoutght = true;
				Debug.Log("Куплено");
				storage.Coins = storage.Coins - current.cost;
				islands[i] = current;
			} else {
				Debug.Log("Не хватает денег");
			}
		} else {
			Debug.Log("Ты уже давно это купил");
		}

		storage.isBoughtIsland[i] = current.isBoutght;
	}

	public void Is1(){
		if(islands[0].isBoutght){
			fade.FadeToLevel();
		}
	}

	public void Is2(){
		Debug.Log(islands[1].isBoutght);
		if(islands[1].isBoutght){
			fade2.FadeToLevel();
		}
	}

	public void Show(int i){
		islands[i].gameObject.SetActive(true); //Чего? Где SetActive(true)
	}

	public void Hide(int i){
		islands[i].gameObject.SetActive(false);
	}
}
