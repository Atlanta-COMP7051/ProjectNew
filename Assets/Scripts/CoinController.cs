using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {


	private GameObject coin;

	// Use this for initialization
	void Start () {		
		coin = GameObject.FindGameObjectWithTag ("Coin");
	}
	
	// Update is called once per frame
	void Update () {		
		coin.transform.Rotate (0, 10, 0);
	}
}