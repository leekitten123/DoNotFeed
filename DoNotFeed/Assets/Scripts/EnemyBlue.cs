using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlue : Enemy {

	void Start () {

		setSpeedMove (0.6f);
	}

	void Update () {

		move ();
	}
}
