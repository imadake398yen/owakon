using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCell : MonoBehaviour {

	[SerializeField] private Text nameLabel;

	public void SetValues (Obstacle obstacle) {
		nameLabel.text = obstacle.gameObject.name;
	}

}
