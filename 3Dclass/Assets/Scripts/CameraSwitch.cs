using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

	public Camera mainCamera;	//定義_攝影機
	public Camera orthCamera;   //定義__攝影機

	//攝影機__化
	void Start(){
		mainCamera.enabled = true;  //__ _攝影機
		orthCamera.enabled = false; //__ __攝影機
	}

	//遊戲__，每_執行一次
	void Update () {
        if (Input.GetKeyDown(KeyCode.S)){	//當....
			mainCamera.enabled = !mainCamera.enabled;   //__攝影機
			orthCamera.enabled = !orthCamera.enabled;   //__攝影機
		}
	}
}
