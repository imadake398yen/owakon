using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	[SerializeField] protected GameObject directionObj;
	public int Cost;
	public Const.ObstacleState State { get; private set; }

	const float rotateSpeed = 10;

	protected void Play () {
		if (State != Const.ObstacleState.Ready) return;
	}

	public void Rotate () {
		transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
	}

}
