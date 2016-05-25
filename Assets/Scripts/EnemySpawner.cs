using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{

	void Start ()
	{
		SetChildActive (false);
	}
		

	void Update()
	{
		if (Check ()) {
			Spawn ();
		}
	}

	bool Check ()
	{
		if (transform.position.y < Game.Instance.PlayerPawn.transform.position.y) {
			return true;
		}
		return false;
	}

	void Spawn ()
	{
		SetChildActive (true);
	}

	void SetChildActive (bool isActive)
	{
		foreach (Transform child in transform) {
			child.gameObject.SetActive (isActive);
		}
	}

}
