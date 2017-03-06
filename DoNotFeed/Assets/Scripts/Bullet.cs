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

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.gameObject.name);

        // 벽에 닿으면 총알 제거
        if (other.gameObject.tag == "TransparentWall")
        {
            Destroy(gameObject);
        }

        if(other.gameObject.name == "Obstacle")
        {
            Destroy(other.gameObject);
        }
    }
}
