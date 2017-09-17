using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableBoxManager : MonoBehaviour {

	private GameObject gameManager;

	// Use this for initialization
	void Start () {
		// ゲームマネージャを取得
		gameManager = GameObject.Find("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// ドラッグ処理
	void OnMouseDrag(){
		// ボールが移動中(落下中)でない場合は箱を動かせるということにする
		if (gameManager.GetComponent<GameManager>().isBallMoving == false)
		{
			// マウスの位置(指の位置?)を取得
			float x = Input.mousePosition.x;
			float y = Input.mousePosition.y;
			float z = 100.0f;

			// 位置を変換してオブジェクトの座標に指定
			// 上記で取得したx,yの位置は画面の左下を(0,0)とするスクリーン座標
			// なので，ゲームオブジェクトが使用するワールド座標に変換する
			transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x,y,z));
		}
	}
}
