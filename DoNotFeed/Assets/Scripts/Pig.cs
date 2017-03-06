using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {

	public int speedMove = 20;
	public int speedRotate = 120;

	public GameObject bullet;
	public GameObject spawnPoint;

	public VirtualJoystick joystickMove;
	public VirtualJoystick joystickRotate;

	private float tempTime;
	private float rotateDegree;

	void start() {}

	void Update () {

		float toMove = speedMove * Time.deltaTime;
		float toRotate = speedRotate * Time.deltaTime;

		float axisYMove = joystickMove.Vertical();
		float axisXMove = joystickMove.Horizontal();

		float axisYRotate = joystickRotate.Vertical();
		float axisXRotate = joystickRotate.Horizontal();

		transform.Translate (new Vector3 (axisYMove * toMove, 0, axisXMove * toMove * (-1)));

		rotateDegree =  Mathf.Atan2(axisXRotate, axisYRotate) * Mathf.Rad2Deg;

		if (isMoveJoystick (axisXRotate, axisYRotate)) {
			transform.rotation = Quaternion.Euler (0f, rotateDegree + 180f, 0f);

			tempTime += Time.deltaTime;

			if (tempTime >= 0.5f) {
				Instantiate(bullet, spawnPoint.transform.position, transform.rotation);
				tempTime = 0;
			}



			Debug.Log (tempTime);
		} else {
			tempTime = 0;
		}

//		if (!isMoveJoystick (dx, dy)) {
//			temp = 0;
//		}
//

			
		if (Input.GetKeyDown(KeyCode.Space)) {
			//Instantiate(bullet, spawnPoint.transform.position, transform.rotation);
		}

	}

	private bool isMoveJoystick(float dx, float dy) {
		
		return ((dx != 0) || (dy != 0));
	}
}