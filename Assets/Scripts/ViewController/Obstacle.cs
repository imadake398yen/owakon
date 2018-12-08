using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	[SerializeField] protected GameObject directionObj;
	public int Cost;
	public Const.ObstacleState State { get; private set; }

	protected void Play () {
		if (State != Const.ObstacleState.Ready) return;
	}

}
