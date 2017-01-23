using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    /** 장애물이 향하는 방향. **/
    Vector3 target;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        /** Pig를 향하여 회전하며 움직인다. **/
        target = GameObject.Find("Pig").transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target, 0.25f);
        transform.Rotate(new Vector3(0, 0, 5));
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.name);

        /** 돼지와 충돌하면 메인 화면으로 이동한다. **/
        if(other.transform.name == "Pig")
        {
            Application.LoadLevel("Start");
        }
    }
}
