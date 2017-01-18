using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigMovement : MonoBehaviour {

    int speed = 20;
    int rotSpeed = 120;

    public GameObject bullet;

    GameObject spawnPoint;
	// Use this for initialization
	void Start () {
        spawnPoint = GameObject.Find("SpawnPoint");
	}
	
	// Update is called once per frame
	void Update () {

        float toMove = speed * Time.deltaTime;
        float toRotate = rotSpeed * Time.deltaTime;

        float front = Input.GetAxis("Vertical");
        float ang = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * front * toMove);
        transform.Rotate(new Vector3(0, ang * toRotate, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, spawnPoint.transform.position, transform.rotation);
            
        }
    }
}
