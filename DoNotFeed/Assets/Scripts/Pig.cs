using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {

	public GameObject bullet;
	public GameObject spawnPoint;

	public VirtualJoystick joystickMove;
	public VirtualJoystick joystickRotate;

	public int speedMove;

	private float toMove;
	private float toRotate;

	private float axisYMove;
	private float axisXMove;
	private float axisYRotate;
	private float axisXRotate;

	private float tempTime;
	private float rotateDegree;

	void start() {
		
	}

	void Update () {

		/** Settings **/
		toMove = speedMove * Time.deltaTime;

		axisYMove = joystickMove.Vertical();
		axisXMove = joystickMove.Horizontal();
		axisYRotate = joystickRotate.Vertical();
		axisXRotate = joystickRotate.Horizontal();

		rotateDegree =  Mathf.Atan2(axisXRotate, axisYRotate) * Mathf.Rad2Deg;

		/** Execution **/
		this.transform.position += new Vector3 (axisYMove * toMove * (-1), 0, axisXMove * toMove);

		if (isMoveJoystick (axisXRotate, axisYRotate)) {
			
			transform.rotation = Quaternion.Euler (0f, rotateDegree + 180f, 0f);
			tempTime += Time.deltaTime;

			if (tempTime >= 0.5f) {
				
				Instantiate(bullet, spawnPoint.transform.position, transform.rotation);
				tempTime = 0;
			}

		} else {
			
			tempTime = 0;
		}			
	}

	private bool isMoveJoystick(float dx, float dy) {
		
		return ((dx != 0) || (dy != 0));
	}
}