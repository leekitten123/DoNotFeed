using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	public void UpdateText (Text source, string str, int num) {

		source.text = str + num;
	}

	public void StartGame () {

		Application.LoadLevel("Stage1");   
	}

	public void EndGame() {
		
		if (Input.GetKey(KeyCode.Escape)) {

			Application.Quit();
		}
	}
}