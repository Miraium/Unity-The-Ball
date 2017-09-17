using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public int StageNo;
	public bool isBallMoving;
	public GameObject ballPrefab;
	public GameObject ball;

	public GameObject goButton;
	public GameObject retryButton;

	// クリア時のテキスト
	public GameObject clearText;

	// オーディオソース
	private AudioSource audioSource;
	public AudioClip clearSE;
	// Use this for initialization
	void Start () {
		// ゲームの初期状態
		retryButton.SetActive(false);
		isBallMoving = false;
		
		// オーディオソースを取得しておく
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PushGoButton(){
		// ボールの重力を有効化
		Rigidbody2D rd = ball.GetComponent<Rigidbody2D>();
		rd.isKinematic = false;

		retryButton.SetActive(true);
		goButton.SetActive(false);
		isBallMoving = true;
	}

	// Retryボタンを推したときの処理
	public void PushRetryButton(){
		Destroy(ball);

		ball = (GameObject)Instantiate(ballPrefab);
		goButton.SetActive(true);
		retryButton.SetActive(false);
		isBallMoving = false;
	}

	// ステージクリア処理
	public void StageClear(){
		// クリア時のテキストをアクティブにすると，テキストが下から現れる．
		// アニメーションは，非アクティブのときは停止しており，アクティブになった瞬間から再生が開始される．
		clearText.SetActive(true);
		retryButton.SetActive(false);

		// 1回だけ効果音を鳴らす
		audioSource.PlayOneShot(clearSE);
	}
}
