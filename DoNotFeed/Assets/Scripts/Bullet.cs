using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int speedMove = 100;

	void Start () {
		
	}
		
	void Update () {
		
        transform.Translate(speedMove * Time.deltaTime, 0, 0);	
	}

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "TransparentWall") {
			
            Destroy(gameObject);
        }

		if (other.gameObject.tag == "Enemy") {
			
            Destroy(other.gameObject);
        }
    }
}
