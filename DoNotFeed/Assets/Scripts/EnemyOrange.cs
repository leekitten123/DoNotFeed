using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrange : Enemy {

	void Start () {
		
		setSpeedMove (0.4f);
	}

	void Update () {

		move ();
    }
}