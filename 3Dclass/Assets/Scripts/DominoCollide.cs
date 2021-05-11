using UnityEngine;
using System.Collections;

public class DominoCollide : MonoBehaviour {

	//當有物件相互即將發生__時，調用OnCollisionEnter()函數
	void OnCollisionEnter(Collision collision)	
	{
		if (collision.gameObject.tag.Equals("Domino"))  //根據碰撞物件的__來判斷該物件是否為___骨牌
			GetComponent<AudioSource>().Play();         //獲取撞擊音效的 AudioSource 元件並__
	}

}
