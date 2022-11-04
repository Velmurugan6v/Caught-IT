using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour {
	public static GameControler instance;
	public int player_health;
	public Text health_text;
	public GameObject restrt_pnel;

	// Use this for initialization
	void Awake(){
		instance = this;
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage(int Amount){
		player_health -= Amount;
		health_text.text = player_health.ToString ();

		if (player_health <= 0) {
			//Restrt Pnel enble
			restrt_pnel.SetActive(true);
			player_health = 0;
			health_text.text = player_health.ToString ();
			player.instance.enabled = false;
		}
	}

	public void Restrt(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void Menu(){
		SceneManager.LoadScene (0);
	}


}
