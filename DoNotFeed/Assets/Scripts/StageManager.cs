using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour {

	public Text textKill;
	public Text textStage;

	private int countKill;
	private int countStage;

	void Start () {

		countKill = 0;
		countStage = 1;
	}

	void Update () {
		
		GameObject.Find ("GameManager").GetComponent<GameManager> ().UpdateText (textKill, "Kill : ", countKill);

		countStage = UpdateStage ();
		GameObject.Find ("GameManager").GetComponent<GameManager> ().UpdateText (textStage, "Stage ", countStage);
	}

	public void setCountKill (int countKill) { this.countKill = countKill; }
	public int getCountKill () { return countKill; }

	private int UpdateStage () {

		return (countKill / 10) + 1;
	}

}
