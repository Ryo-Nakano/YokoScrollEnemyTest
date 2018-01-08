using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapEnemyController : MonoBehaviour {

	[SerializeField] float dropSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(this.transform.position.y > 1.1f)//地面に接地するまで呼ばれる
		{
			this.transform.position += new Vector3 (0, -dropSpeed * Time.deltaTime, 0);//下に移動
		}
	}


}
