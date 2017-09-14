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

	// Use this for initialization
	void Start () {
		retryButton.SetActive(false);
		isBallMoving = false;
		
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

	public void PushRetryButton(){
		Destroy(ball);

		ball = (GameObject)Instantiate(ballPrefab);
		goButton.SetActive(true);
		retryButton.SetActive(false);
		isBallMoving = false;
	}
}
