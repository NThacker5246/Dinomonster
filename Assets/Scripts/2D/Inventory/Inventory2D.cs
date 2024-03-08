using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory2D : MonoBehaviour
{
	public bool[] isFull;
	public int isHOT;
	public GameObject[] slots;
	public GameObject inventory;
	private bool inventoryOn;

	private void Start()
	{
		inventoryOn = false;
		// Здесь можно добавить код предварительной загрузки
	}

	private void Update()
	{
		CheckInput();
	}

	private void CheckInput()
	{
		if (Input.GetKeyDown(KeyCode.Q))
		{
			DropItemAtHotSlot();
		}
		CheckHotkeyInput();
	}

	private void DropItemAtHotSlot()
	{
		slots[isHOT].GetComponent<Slot2D>().DropItem();
	}

	private void CheckHotkeyInput()
	{
		for (int i = 1; i <= 7; i++)
		{
			if (Input.GetKeyDown(KeyCode.Alpha0 + i))
			{
				isHOT = i - 1;
			}
		}
	}

	public void Chest()
	{
		inventoryOn = !inventoryOn;
		inventory.SetActive(inventoryOn);
	}
}
