using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectManager : MonoBehaviour {
	// ステージ選択用のボタンを配列で管理
	public GameObject[] stageButtons;

	// Use this for initialization
	void Start () {
		// どのステージまでクリアしているのかをロードする
		// デフォルト値は0としておく．(セーブ前なら0が代入される)
		int clearStageNo = PlayerPrefs.GetInt("CLEAR", 0);

		// ステージボタンを有効化
		for (int i = 0; i <= stageButtons.GetUpperBound(0); i++)
		{
			bool b;
			if (clearStageNo < i)
			{
				// 前ステージをクリアしていないのなら無効
				b = false;
			}else
			{
				// 前ステージをクリアしているのなら有効
				b = true;
			}

			// ボタンに対して設定
			stageButtons[i].GetComponent<Button>().interactable = b;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PushStageSelectButton(int stageNo){
		// 指定された番号のゲームシーンへ
		SceneManager.LoadScene("PuzzleScene"+stageNo);
	}
}
