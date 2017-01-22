using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    Vector3 target;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        target = GameObject.Find("Pig").transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, 0.25f);
        transform.Rotate(new Vector3(0, 0, 5));
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name);

        if(other.transform.name == "Pig")
        {
            Application.LoadLevel("Stage1");
        }
    }
}
