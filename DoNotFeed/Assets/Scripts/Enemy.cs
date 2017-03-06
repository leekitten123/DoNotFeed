using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	protected float speedMove;
	protected Vector3 targetVector;

	public void setSpeedMove (float speedMove) { this.speedMove = speedMove; }
	public void setTargetVector (Vector3 targetVector) { this.targetVector = targetVector; }

	public float getSpeedMove () { return this.speedMove; }
	public Vector3 getTargetVector () { return targetVector; }
}