using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour {

	public float perspectiveZoomSpeed = 0.3f;        // 透視投影モードでの有効視野の変化の速さ  
	private Camera cam;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera>();
		
	}
	
	// Update is called once per frame
	void Update () {
		// 端末に 2 つのタッチがあるならば...　
		if (Input.touchCount == 2)
		{
			// 両方のタッチを格納します
			Touch touchZero = Input.GetTouch(0);
			Touch touchOne = Input.GetTouch(1);

			// 各タッチの前フレームでの位置をもとめます
			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			// 各フレームのタッチ間のベクター (距離) の大きさをもとめます
			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			// 各フレーム間の距離の差をもとめます
			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

				// そうでない場合は、タッチ間の距離の変化に基づいて有効視野を変更します
				cam.fieldOfView += deltaMagnitudeDiff * perspectiveZoomSpeed;

				// 有効視野を 0 から 180 の間に固定するように気を付けてください
				cam.fieldOfView = Mathf.Clamp(cam.fieldOfView, 40f, 110f);
		}
	}
}
