using UnityEngine;
using System.Collections.Generic;

public class Bullet : MonoBehaviour
{

	readonly static Stack<Bullet> _BulletPool = new Stack<Bullet> ();

	public const string BULLET_PREFAB_PATH = "Bullets/Bullet";
	public static Bullet LoadedBulletPrefab;

	public float _Speed = 15.0F;
	public float _Dead_Y = 30.0F;

	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += Vector3.up * _Speed * Time.deltaTime;
		if(transform.position.y > _Dead_Y){
			_BulletPool.Push(this);
			gameObject.SetActive(false);
		}
	}

	public static Bullet Get ()
	{
		if (_BulletPool.Count > 0) {
			Bullet bullet = _BulletPool.Pop ();
			bullet.gameObject.SetActive(true);
			return bullet; 
		}

		if (LoadedBulletPrefab == null) {
			
			LoadedBulletPrefab = Resources.Load<Bullet> (BULLET_PREFAB_PATH);
		}

		return Instantiate<Bullet> (LoadedBulletPrefab);

	}
}
