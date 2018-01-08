using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedEnemyController : MonoBehaviour {

	int moveDirection = 0;//敵の動く方向
	//0のとき→上
	//1のとき→下


	[SerializeField] float moveSpeed;//移動の速さ

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//AdvancedeEnemyが動く方向を判断する為のフラグを切り替え
		if(this.transform.position.y > 10f)
		{
			moveDirection = 1;//下に動くフラグ
			Debug.Log("MoveDown");
		}
		else if(this.transform.position.y < 5f)
		{
			moveDirection = 0;//上に動くフラグ
			Debug.Log("MoveUp");
		}

		//フラグに応じてAdvancedEnemyが移動
		if(moveDirection == 0)
		{
			MoveUP ();//上に動く
		}
		else if(moveDirection == 1)
		{
			MoveDown ();//下に動く
		}
	}

	//上に移動
	void MoveUP()
	{
		this.transform.position += new Vector3 (0, moveSpeed * Time.deltaTime, 0);
	}

	//下に移動
	void MoveDown()
	{
		this.transform.position += new Vector3 (0, -moveSpeed * Time.deltaTime, 0);
	}
}
