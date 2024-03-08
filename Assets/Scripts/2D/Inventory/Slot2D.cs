using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot2D : MonoBehaviour
{
	public Inventory2D inventory;
	public int i;
	private void Update()
	{
		if(transform.childCount <= 0)
		{
			inventory.isFull[i] = false;
		}
	}

	public void DropItem()
	{
		foreach(Transform child in transform)
		{
			child.GetComponent<Spawn2D>().SpawnDroppedItem();
			GameObject.Destroy(child.gameObject);
		}
	}
}