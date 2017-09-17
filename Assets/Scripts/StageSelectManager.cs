using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PushStageSelectButton(int stageNo){
		// 指定された番号のゲームシーンへ
		SceneManager.LoadScene("PuzzleScene"+stageNo);
	}
}
