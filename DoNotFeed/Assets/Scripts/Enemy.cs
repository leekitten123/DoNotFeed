using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	private float speedMove;
	private Vector3 targetVector;

	protected void setSpeedMove (float speedMove) { this.speedMove = speedMove; }
	protected void setTargetVector (Vector3 targetVector) { this.targetVector = targetVector; }

	public float getSpeedMove () { return this.speedMove; }
	public Vector3 getTargetVector () { return targetVector; }

	protected void move () {

		setTargetVector(GameObject.Find("Pig").transform.position);

		transform.position = Vector3.MoveTowards(transform.position, getTargetVector(), getSpeedMove());

		transform.Rotate(new Vector3(0, 0, 5));
	}

	private void OnTriggerEnter (Collider other) {

		//Debug.Log (other.gameObject.name);
        if (other.gameObject.name == "Pig") {
			
            Application.LoadLevel("Start");
        }

		if (other.gameObject.name == "Bullet") {

			Destroy (this.gameObject);
		}
    }
}