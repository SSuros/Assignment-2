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
		
		if (col.gameObject.name == "Enemy(Clone)")
		{
			col.gameObject.SetActive(false);
			FindObjectOfType<AudioManager>().Play("Hurt");
			Object.Destroy(this.gameObject);
		}

		if (col.gameObject.name == "EnemySmall(Clone)")
		{
			col.gameObject.SetActive(false);
			FindObjectOfType<AudioManager>().Play("Hurt");
			Object.Destroy(this.gameObject);
		}


		if (col.gameObject.name == "Top")
		{
			Object.Destroy(this.gameObject);
		}

		if (col.gameObject.name == "Boss(Clone)")
		{
			FindObjectOfType<LoseLifeBoss>().BossLoseLife();
			Object.Destroy(this.gameObject);
			FindObjectOfType<AudioManager>().Play("Hurt");
			
		}
	}
}
