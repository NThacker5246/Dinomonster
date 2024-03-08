using UnityEngine;

public class ShopDino : MonoBehaviour
{
	[SerializeField] private sceneManeger sceneManeger;

	public void Next()
	{
		sceneManeger.EnterScene("Shop");     
	}
}
