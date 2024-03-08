using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2D : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    public int id;

    private void Start()
    {
    	player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
    	Vector3 playerPos = new Vector3(player.position.x, player.position.y + 200, 0f);
    	Instantiate(item, playerPos, Quaternion.identity);
    }
}
