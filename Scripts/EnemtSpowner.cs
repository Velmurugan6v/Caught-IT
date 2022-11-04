using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtSpowner : MonoBehaviour {

	public Transform[] spown_pos;
	public GameObject[] enemies;
	public float spown_btw_time;
	public float spown_Counter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (spown_Counter <= 0) {
			Spown_Enemy ();
			spown_Counter = spown_btw_time;
		} else {
			spown_Counter -= Time.deltaTime;
		}
	}

	void Spown_Enemy(){
		int rp = Random.Range (0, spown_pos.Length);
		int re = Random.Range (0, enemies.Length);
		Instantiate (enemies [re], spown_pos [rp].position, Quaternion.identity);
	}
}
