using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Storage : ScriptableObject
{
	public int island;
	public int Coins;
	public int Eggs;

	//координаты игрока при последнем сохранении
	public Vector3 PlayerPos3D;
	public Vector2 PlayerPos2D;

	//куплены ли предметы
	public bool[] isBoughtIsland;
}
