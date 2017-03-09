using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGreen : Enemy {

	void Start () {

		setSpeedMove (0.5f);
	}

	void Update () {

		move ();
	}
}
