using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPageScript : MonoBehaviour {
	
	public GameObject RedBallPrefab; 
	public GameObject BlueBallPrefab;
	public GameObject YellowBallPrefab;
	public GameObject GreenBallPrefab;
	public GameObject WhiteBallPrefab;
	public GameObject SoccerBallPrefab;

	private int num;
	private int[] orderofballs = new int[100];

	private int Ballnumber;

	//クリックした場所を入れるための変数も宣言するよ
	private Vector3 clickPosition;

	// Use this for initialization
	void Start () {
		for(int i = 0; i<100 ; i++){
			num = Random.Range (1, 101);
			orderofballs [i] = num;
		}

		Ballnumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && Ballnumber<100) {

			//クリックした場所を取得して変数clickPositionに入れておく
			clickPosition = Input.mousePosition;

			//今のままではクリックした場所(手前)にボールが落ちてしまうので奥の方向(Z軸側)にPrefabのインスタンスを作る位置をズラす
			clickPosition.z = 1f;


			if (orderofballs [Ballnumber] <= 14) {
				//Prefabからインスタンスを生成し、RedBallという変数に入れる。
				//Camera.main.ScreenToWorldPoint(clickPosition)とすることでクリックした場所にインスタンスを生成できる
				GameObject Ball = Instantiate (RedBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), RedBallPrefab.transform.rotation);
				//作ったインスタンスに力をかけて投げたような動きにする
				Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 300));

			} else if (orderofballs [Ballnumber] > 14 && orderofballs [Ballnumber] <= 28) {
				GameObject Ball = Instantiate (BlueBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), RedBallPrefab.transform.rotation);
				Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 300));

			} else if (orderofballs [Ballnumber] > 28 && orderofballs [Ballnumber] <= 42) {
				GameObject Ball = Instantiate (YellowBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), RedBallPrefab.transform.rotation);
				Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 300));

			} else if (orderofballs [Ballnumber] > 42 && orderofballs [Ballnumber] <= 56) {
				GameObject Ball = Instantiate (GreenBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), RedBallPrefab.transform.rotation);
				Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 300));

			} else if (orderofballs [Ballnumber] > 56 && orderofballs [Ballnumber] <= 70) {
				GameObject Ball = Instantiate (WhiteBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), RedBallPrefab.transform.rotation);
				Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 300));

			} else if (orderofballs [Ballnumber] > 70 && orderofballs [Ballnumber] <= 100) {
				GameObject Ball = Instantiate (SoccerBallPrefab, Camera.main.ScreenToWorldPoint (clickPosition), RedBallPrefab.transform.rotation);
				Ball.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 100, 300));
			}

			Ballnumber += 1;
				
		}

	}
}
	