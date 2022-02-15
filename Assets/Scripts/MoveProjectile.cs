using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{

	public Rigidbody2D projectile;

	public float moveSpeed = 10.0f;

	
	void Start()
	{
		projectile = this.gameObject.GetComponent<Rigidbody2D>();
	}

	
	void Update()
	{
		projectile.velocity = new Vector2(0, 1) * moveSpeed;
	}

	
	void OnCollisionEnter2D(Collision2D col)
	{
		
		if (col.gameObject.name == "Enemy")
		{
			col.gameObject.SetActive(false);
		}

		if (col.gameObject.name == "EnemySmall")
		{
			col.gameObject.SetActive(false);
		}

		if (col.gameObject.name == "Top")
		{
			Object.Destroy(this.gameObject);
		}
	}
}
