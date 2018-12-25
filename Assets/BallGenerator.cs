using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallGenerator : MonoBehaviour {

	//RedBallPrefabを入れるためのゲームオブジェクトを作っておこう
	public GameObject RedBallPrefab; 
	public GameObject BlueBallPrefab;
	public GameObject YellowBallPrefab;
	public GameObject GreenBallPrefab;
	public GameObject WhiteBallPrefab;
	public GameObject SoccerBallPrefab;
	public GameObject SpecialCubePrefab;

	private GameObject stateText;
	private GameObject scoreText;

	private int num;
	private int[] orderofballs = new int[100];
	public static int Ballnumber;


	//クリックした場所を入れるための変数も宣言するよ
	private Vector3 clickPosition;


	// Use this for initialization
	void Start () {
		this.stateText = GameObject.Find("NextBallText");

		for(int i = 0; i<100 ; i++){
			num = Random.Range (1, 101);
			orderofballs [i] = num;
		}

		Ballnumber = 0;

		this.scoreText = GameObject.Find("ScoreText");
		this.scoreText.GetComponent<Text> ().text = "スコア 0" ;

	}
	
	// Update is called once per frame
	void Update () {
			//左クリックをしたとき
		if (Input.touchCount == 1 && Input.GetMouseButtonDown (0) && Ballnumber<100) {
			
				//クリックした場所を取得して変数clickPositionに入れておく
				clickPosition = Input.mousePosition;

				//今のままではクリックした場所(手前)にボールが落ちてしまうので奥の方向(Z軸側)にPrefabのインスタンスを作る位置をズラす
				clickPosition.z = 13f;


				if (orderofballs [Ballnumber] <= 14) {
					//Prefabからインスタンスを生成し、RedBallという変数に入れる。
					//Camera.main.ScreenToWorldPoint(clickPosition)とすることでクリックした場所にインスタンスを生成できる
					GameObject Ball = Instantiate (RedBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), RedBallPrefab.transform.rotation);
					//作ったインスタンスに力をかけて投げたような動きにする
					Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 110));

				} else if (orderofballs [Ballnumber] > 14 && orderofballs [Ballnumber] <= 28) {
					GameObject Ball = Instantiate (BlueBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), BlueBallPrefab.transform.rotation);
					Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 110));

				} else if (orderofballs [Ballnumber] > 28 && orderofballs [Ballnumber] <= 42) {
					GameObject Ball = Instantiate (YellowBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), YellowBallPrefab.transform.rotation);
					Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 110));

				} else if (orderofballs [Ballnumber] > 42 && orderofballs [Ballnumber] <= 56) {
					GameObject Ball = Instantiate (GreenBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), GreenBallPrefab.transform.rotation);
					Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 110));

				} else if (orderofballs [Ballnumber] > 56 && orderofballs [Ballnumber] <= 70) {
					GameObject Ball = Instantiate (WhiteBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), WhiteBallPrefab.transform.rotation);
					Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 110));

				} else if (orderofballs [Ballnumber] > 70 && orderofballs [Ballnumber] <= 98) {
					GameObject Ball = Instantiate (SoccerBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), SoccerBallPrefab.transform.rotation);
					Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 110));

				} else if (orderofballs [Ballnumber] > 98 && orderofballs [Ballnumber] <= 100) {
				GameObject Ball = Instantiate (SpecialCubePrefab, Camera.main.ScreenToWorldPoint (clickPosition), SpecialCubePrefab.transform.rotation);
				Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 110));

				}


				int nextcolor = Ballnumber + 1;

				if (orderofballs [nextcolor] <= 14) {
					Text text = this.stateText.GetComponent<Text> ();
					text.text = "Next > Red";
					text.color = new Color (1.0f, 0.0f, 0.0f, 1.0f);


				} else if (orderofballs [nextcolor] > 14 && orderofballs [nextcolor] <= 28) {
					Text text = this.stateText.GetComponent<Text> ();
					text.text = "Next > Blue";
					text.color = new Color (75.0f / 255.0f, 166.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);

				} else if (orderofballs [nextcolor] > 28 && orderofballs [nextcolor] <= 42) {
					Text text = this.stateText.GetComponent<Text> ();
					text.text = "Next > Yellow";
					text.color = new Color (251.0f / 255.0f, 253.0f / 255.0f, 69.0f / 255.0f, 255.0f / 255.0f);

				} else if (orderofballs [nextcolor] > 42 && orderofballs [nextcolor] <= 56) {
					Text text = this.stateText.GetComponent<Text> ();
					text.text = "Next > Green";
					text.color = new Color (83.0f / 255.0f, 253.0f / 255.0f, 89.0f / 255.0f, 255.0f / 255.0f);

				} else if (orderofballs [nextcolor] > 56 && orderofballs [nextcolor] <= 70) {
					Text text = this.stateText.GetComponent<Text> ();
					text.text = "Next > White";
					text.color = new Color (255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);

				} else if (orderofballs [nextcolor] > 70 && orderofballs [nextcolor] <= 98) {
					Text text = this.stateText.GetComponent<Text> ();
					text.text = "Next > Soccer ball";
					text.color = new Color (255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 230.0f / 255.0f);

				} else if (orderofballs [nextcolor] > 98 && orderofballs [nextcolor] <= 100) {
					Text text = this.stateText.GetComponent<Text> ();
					text.text = "Next > Rainbow Cube";
				text.color = new Color (43.0f / 255.0f, 248.0f / 255.0f, 16.0f / 255.0f, 255.0f / 255.0f);
				}

				
				this.scoreText.GetComponent<Text> ().text = "スコア " + nextcolor;
		
				Ballnumber += 1;
			}

		}
		

}
