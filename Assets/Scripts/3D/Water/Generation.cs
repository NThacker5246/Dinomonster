using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
	public int size;
	public float quality;
	public int mn;
	public float speed = 1f; // Скорость движения текстуры
	public Vector2 direction = new Vector2(0f, 1f); // Направление движения текстуры

	// Start is called before the first frame update
	void Start()
	{
		//Render();
	}

	public void Render(){
		Texture2D texture = new Texture2D(size, size);
		this.gameObject.GetComponent<Renderer>().material.mainTexture = texture;
		for (int y = 0; y < texture.height; y++){
			for (int x = 0; x < texture.width; x++){
				int posX = Random.Range(mn, x);
				int posY = Random.Range(mn, y);
				float c = (posX ^ posY) % quality / (quality-1);
				Color color = new Color(c, c, c);
				texture.SetPixel(x, y, color);
			}
		}
		texture.Apply();
	}

	void Update()
	{
		//Render(); 
		// Изменяем смещение текстуры по оси Z в соответствии со скоростью и направлением
		float offset = Time.time * speed;
		GetComponent<Renderer>().material.SetTextureOffset("_MainTex", direction * offset);
	}

}
