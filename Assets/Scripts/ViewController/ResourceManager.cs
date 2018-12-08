using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
: SingletonMonoBehaviour<ResourceManager> {

	[SerializeField] private List<Obstacle> obstacles;
	public static List<Obstacle> Obstacles { get{ return instance.obstacles; } }

}
