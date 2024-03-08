using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC2D : MonoBehaviour
{
	public float speed;
	public Storage st;
	public Rigidbody2D rb;

	// Start is called before the first frame update
	void Start()
	{
		transform.position = new Vector3(st.PlayerPos2D.x, st.PlayerPos2D.y, this.transform.position.z);
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		float horizontal = Input.GetAxis("Horizontal")*speed;
		float vertical = Input.GetAxis("Vertical")*speed;

		transform.position += new Vector3(horizontal, vertical, 0f);
		//rb.AddForce(new Vector2(horizontal, vertical));
		//Debug.Log(horizontal);
		//Debug.Log(vertical);
	}
}
