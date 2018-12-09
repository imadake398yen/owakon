using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Model;

public class StageManager
: SingletonMonoBehaviour<StageManager> {

	[SerializeField] private List<Transform> points;
	public List<Transform> Points { get{ return points; } }

	private void Awame () {
		Stage.Init();
	}

}
