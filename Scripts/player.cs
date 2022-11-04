using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public static player instance;
	public Rigidbody2D rb;
	public float move_speed;
	public float move_input;
	// Use this for initialization
	void Awake(){
		instance = this;
	}

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		move_input = Input.GetAxisRaw ("Horizontal");

	}

	void FixedUpdate(){
		rb.velocity = new Vector2 (move_input * move_speed * Time.deltaTime, rb.velocity.y);
	}

}
