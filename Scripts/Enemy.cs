using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float move_speed;

	// Use this for initialization
	void Start () {
		Invoke ("Die", 5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.down * move_speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Die ();
		}

		if (other.tag == "Ground") {
			GameControler.instance.TakeDamage (1);
		}
	}

	void Die(){
		Destroy (this.gameObject);
	}
}
