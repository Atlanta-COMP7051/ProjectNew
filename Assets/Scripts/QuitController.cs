using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickRestart(){
		SceneManager.LoadScene (1);
	}

	public void OnClickQuit(){
		Application.Quit ();
	}
}
