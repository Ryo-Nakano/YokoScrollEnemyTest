using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapArea : MonoBehaviour {

	[SerializeField] GameObject trapEnemy;
	Vector3 trapEnemySpawnPosition = new Vector3(10f, 15f, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Player")
		{
			Instantiate (trapEnemy, trapEnemySpawnPosition, Quaternion.identity);
			Destroy (this.gameObject);
		}
	}
}
