﻿using UnityEngine;
using System.Collections;

public class leftrightbottom : MonoBehaviour {
	public Transform bulletPrefab;
	void Start() {
		Transform bullet = Instantiate(bulletPrefab) as Transform;
		//Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "air") {
			Physics2D.IgnoreCollision(col.collider, GetComponent<Collider2D>());
			//Destroy (col.gameObject);
			//	fishTotal = fishTotal + 1;
		}
		if (col.gameObject.tag == "urchin") {
			Physics2D.IgnoreCollision(col.collider, GetComponent<Collider2D>());
		}
		if (col.gameObject.tag == "fish") {
			Destroy (col.gameObject);
			//	fishTotal = fishTotal + 1;
		}
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "fish") {
			Destroy (collider.gameObject);
		}
	}
}
