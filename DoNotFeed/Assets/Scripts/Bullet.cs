using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int speedMove = 100;

	public StageManager stageManager;

	void Start () {
		
		stageManager = GameObject.Find ("StageManager").GetComponent<StageManager> ();
	}
		
	void Update () {
		
        transform.Translate(speedMove * Time.deltaTime, 0, 0);	
	}

    private void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "Enemy") {
			
			Destroy(other.gameObject);
			Destroy (gameObject);

			stageManager.setCountKill(stageManager.getCountKill () + 1);
        }
    }

}
