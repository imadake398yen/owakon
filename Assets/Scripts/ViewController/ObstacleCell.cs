using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleCell : MonoBehaviour {

	[SerializeField] private Text nameLabel;
	private Button button;
	private Image buttonImage;

	private Obstacle obstaclePrefab;
	private bool isSelected = false;

	public void SetValues (Obstacle obstacle) {
		obstaclePrefab = obstacle;
		nameLabel.text = obstacle.gameObject.name;
		button = GetComponent<Button>();
		buttonImage = GetComponent<Image>();
		button.onClick.AddListener(() => {
			if (Placer.LastPushObstacleCell != null) {
				Placer.LastPushObstacleCell.ToCancelSelectColor();
			}
			Placer.SelectObstacle(obstacle, this);
			buttonImage.color = new Color(0.8f, 0.8f, 1f, 1f);
			MainCameraController.instance.ChangeState(Const.CameraState.PlaceObstacle);
		});
	}

	public void ToCancelSelectColor () {
		buttonImage.color = Color.white;
	}

}
