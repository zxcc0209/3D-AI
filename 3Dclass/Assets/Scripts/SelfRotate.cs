using UnityEngine;
using System.Collections;

public class SelfRotate : MonoBehaviour {

	public float rotateSpeed = 40.0f;   //定義旋轉速度

	//每_執行一次：物體自轉
	void Update () {
		//物體以__坐標系的向_方向（正_軸）方向，以 rotateSpeed 的速度進行順時針自轉
		//Time.deltaTime 表示該_的執行時間，Time.deltaTime * rotateSpeed 表示該_總共自轉的角度
		transform.Rotate (Vector3.up, Time.deltaTime * rotateSpeed);	
	}
}
