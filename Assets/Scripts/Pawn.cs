using UnityEngine;
using System.Collections;

public class Pawn : MonoBehaviour
{
	public float _speed = 1.5F;
	public float _BulletFireDelay;

	float _LastBulletTime = 0.0F;



	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 input = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);

		transform.position += input * _speed * Time.deltaTime;

		if(Input.GetKey(KeyCode.Space)){
			Fire();	
		}
	}

	void Fire(){
		if(Time.time < _LastBulletTime + _BulletFireDelay){
			return;
		}
		_LastBulletTime = Time.time;

		Bullet.Get().transform.position = transform.position;
	}
}

