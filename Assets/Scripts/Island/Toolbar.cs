using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Toolbar : MonoBehaviour
{
	public Text coins;
	public Text eggs;
	public Storage st;

	void Update(){
		if(coins.text != st.Coins.ToString()){
			coins.text = st.Coins.ToString();
		}
		if(eggs.text != st.Eggs.ToString()){
			eggs.text = st.Eggs.ToString();
		}
	}
}
