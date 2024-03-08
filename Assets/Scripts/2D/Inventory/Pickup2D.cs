using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup2D : MonoBehaviour
{
	private Inventory2D inventory;
	public GameObject slotButton;
	public int id;

	private void Start()
	{
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory2D>();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("Player"))
		{
			for(int i = 0; i < inventory.slots.Length; i++)
			{
				if(inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(slotButton, inventory.slots[i].transform);
					Destroy(gameObject);
					break;
				}
			}
		}
	}
}
