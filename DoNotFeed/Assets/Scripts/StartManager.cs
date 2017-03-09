using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour {

    void Start() {

    }
		
    void Update() {
		
		if (Application.platform == RuntimePlatform.Android) {

			GameObject.Find ("GameManager").GetComponent<GameManager> ().EndGame ();
		}
    }

    public void StartGame() {
		
		GameObject.Find ("GameManager").GetComponent<GameManager> ().StartGame ();
    }
}
