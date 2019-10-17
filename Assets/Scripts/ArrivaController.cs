using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrivaController : MonoBehaviour {


	private GameObject arrive;
	// Use this for initialization
	void Start () {
		arrive = GameObject.FindGameObjectWithTag ("Arrive");
		arrive.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
