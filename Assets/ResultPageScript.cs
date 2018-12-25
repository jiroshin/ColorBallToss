using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultPageScript : MonoBehaviour {

	private int score;
	private GameObject scoretext;
	private GameObject commentText;

	// Use this for initialization
	void Start () {
		this.score = BallGenerator.Ballnumber;
		this.scoretext = GameObject.Find("ResultText");
		this.commentText = GameObject.Find("Comment");

		this.scoretext.GetComponent<Text> ().text = "スコア " + this.score;
	}
	
	// Update is called once per frame
	void Update () {
		if(score < 5){
			this.commentText.GetComponent<Text> ().text = "ミスタッチさせてごめんね";

		}else if(score < 30){
			this.commentText.GetComponent<Text> ().text = "君の実力はそんなもんじゃない！";

		}else if(score < 40){
			this.commentText.GetComponent<Text> ().text = "まだまだ！もっともっと！！";

		}else if(score < 50){
			this.commentText.GetComponent<Text> ().text = "このへんから難しいんだよね";

		}else if(score < 60){
			this.commentText.GetComponent<Text> ().text = "もう一息！君ならできる！！";

		}else if(score < 70){
			this.commentText.GetComponent<Text> ().text = "すごいよ！！うまいんだね";

		}else if(score < 80){
			this.commentText.GetComponent<Text> ().text = "すごすぎる・・・。プロですか？";

		}else if(score < 90){
			this.commentText.GetComponent<Text> ().text = "どうなってんの！？うますぎる！";

		}else if(score < 101){
			this.commentText.GetComponent<Text> ().text = "神の領域です。リスペクト。";

		}

	}

	public void Restart() {
		SceneManager.LoadScene ("GameScene");
	}

	public void toTitle() {
		SceneManager.LoadScene ("TopScene");
	}
}
