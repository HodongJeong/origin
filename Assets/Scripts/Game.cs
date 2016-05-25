using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
	public static Game Instance;

	public GameObject PlayerPawnPrefab;


	[HideInInspector]
	public GameObject PlayerPawn;


	void Start ()
	{
		Instance = this;

		PlayerPawn = Instantiate (PlayerPawnPrefab);
	}

}
