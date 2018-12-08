using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager
: SingletonMonoBehaviour<StageManager> {

	[SerializeField] private List<Transform> points;
	public List<Transform> Points { get{ return points; } }

}
