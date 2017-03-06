using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCandy : Enemy {

	void Start () {

		setSpeedMove (0.4f);
	}

	void Update () {

		setTargetVector(GameObject.Find("Pig").transform.position);

		transform.position = Vector3.MoveTowards(transform.position, getTargetVector(), getSpeedMove());

		//transform.Rotate(new Vector3(0, 0, 5));
	}

	private void OnTriggerEnter (Collider other) {

		if(other.transform.name == "Pig") {

			Application.LoadLevel("Start");
		}
	}
}
