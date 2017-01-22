using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    GameObject pig;

	// Use this for initialization
	void Start () {
        pig = GameObject.Find("Pig");
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(pig.transform.position.x + 35, pig.transform.position.y + 35, pig.transform.position.z - 4);
	}
}
