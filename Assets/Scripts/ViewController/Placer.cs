using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placer {

	public static void SelectObstacle (Obstacle obstacle, ObstacleCell cell) {
		SelectedObstacle = obstacle;
		LastPushObstacleCell = cell;
	}
	public static void CancelSelect () {
		SelectedObstacle = null;
		LastPushObstacleCell = null;
	}
	public static Obstacle SelectedObstacle { get; private set; }
	public static ObstacleCell LastPushObstacleCell { get; private set; }

}
