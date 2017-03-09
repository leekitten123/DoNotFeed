using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : Enemy {

	void Start () {

		setSpeedMove (0.3f);
	}

	void Update () {

		move ();
	}
}
