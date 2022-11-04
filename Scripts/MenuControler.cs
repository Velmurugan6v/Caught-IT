using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControler : MonoBehaviour {

	public void Ply(){
		SceneManager.LoadScene (1);
	}

	public void Exit(){
		Application.Quit ();
	}
}
