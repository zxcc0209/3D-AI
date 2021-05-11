using UnityEngine;
using System.Collections;

public class RotateAroundAndLookAt : MonoBehaviour {

	public GameObject rotateCenter;     //定義____物件對象
	public float rotateSpeed = 10.0f;   //旋轉__

	//每_執行一次：物件_轉
	void Update () {
		if (rotateCenter) {		//當旋轉中心對象__時才進行物體公轉
			transform.RotateAround (	
				rotateCenter.transform.position,    //旋轉___
				rotateCenter.transform.up,          //旋轉_：此處設置為為旋轉中心的向_方向（正_軸）
				Time.deltaTime * rotateSpeed        //旋轉的__，rotateSpeed表示旋轉的速度，Time.deltaTime表示該_執行的時間
			);
			transform.LookAt(rotateCenter.transform);   //使遊戲物件始終__旋轉中心
		}
	}
}
