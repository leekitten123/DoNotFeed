using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZone : MonoBehaviour {

	public GameObject enemyRed;
	public GameObject enemyOrange;
	public GameObject enemyGreen;
	public GameObject enemyBlue;

	private GameObject[] enemy = new GameObject[4];

	private float tempTime;

	void Start () {

		enemy [0] = enemyRed;
		enemy [1] = enemyOrange;
		enemy [2] = enemyGreen;
		enemy [3] = enemyBlue;

		tempTime = 0;
	}

	void Update () {

		tempTime += Time.deltaTime;

		if (tempTime >= 2) {

			Instantiate (setEnemy (), RandomPosition (), transform.rotation);

			tempTime = 0;

			Debug.Log(RandomPosition ());
		}
	}

	private Vector3 RandomPosition () {
		float x;
		float z;

		//Debug.Log (isTrue (Random.value));

		if (isTrue (Random.value)) {

			x = isTrue (Random.value) ? 180 : -180;

			z = Random.value * 360 - 180;
		} else {

			z = isTrue (Random.value) ? 180 : -180;

			x = Random.value * 360 - 180;
		}

		return new Vector3 (x, 0, z);
	}

	private bool isTrue (float value) {

		return (value >= 0.5f) ? true : false ;
	}

	private GameObject setEnemy () {
		
		return enemy [(int)(Random.value * 4)];
	}
}