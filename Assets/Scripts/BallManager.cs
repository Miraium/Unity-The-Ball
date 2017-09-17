using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll){
		// OutAreaとの衝突判定
		if (coll.gameObject.tag == "OutArea")
		{
			// ゲームマネージャを取得
			GameObject gameManager = GameObject.Find("GameManager");
			// リトライ
			gameManager.GetComponent<GameManager>().PushRetryButton();
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		// Collider2Dからのトリガーで呼ばれる関数?
		// ClearAreaというタグが付いているオブジェクトであることをチェック
		if (other.gameObject.tag == "ClearArea")
		{
			GameObject gameManager = GameObject.Find("GameManager");
			gameManager.GetComponent<GameManager>().StageClear();
		}
	}
}
