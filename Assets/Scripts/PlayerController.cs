using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] float speed;//Playerの移動スピード
	[SerializeField] float jumpPower;//Playerのjumpのパワー
	int jumpCpunt = 0;
	Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();//Playerの移動
		Jump ();//PLayer
	}


	//====================以下、自作の関数====================

	//Playerに移動をさせる関数
	void Move()
	{
		if(Input.GetKey("right"))
		{
			this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
		}

		if(Input.GetKey("left"))
		{
			this.transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);
		}
	}


	//PlayerにJumpをさせる関数
	void Jump()
	{
		if(Input.GetKeyDown("space"))
		{
			if(jumpCpunt < 2)
			{
				rigidbody.velocity = new Vector3 (0, jumpPower, 0);
				jumpCpunt++;//jumpCountに1足す
			}
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Ground")
		{
			jumpCpunt = 0;//jumpCountの初期化
		}
	}
}
