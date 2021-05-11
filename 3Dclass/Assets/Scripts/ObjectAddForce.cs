using UnityEngine;
using System.Collections;

public class ObjectAddForce : MonoBehaviour {

	public int force;   //定義___大小

	//每隔固定時間執行一次，用於__模擬
	void FixedUpdate () {
		gameObject.GetComponent<Rigidbody>()        //獲取遊戲物件上的__元件
			.AddForce (new Vector3(0,-force,0));    //給__添加__方向的作用力
	}

}
