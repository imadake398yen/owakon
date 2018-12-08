using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleList : MonoBehaviour {

	[SerializeField] private ObstacleCell obstaceCellPrefab;
	[SerializeField] private Transform obstaceCellParent, openPoint, closePoint;
	[SerializeField] private Button openButton, closeButton;

	private float easing = 10.0f;
	private bool isOpen, isMoving;

	private void Start () {
		foreach (var o in ResourceManager.Obstacles) {
			var obstacleCell = Instantiate(obstaceCellPrefab) as ObstacleCell;
			obstacleCell.transform.SetParentWithReset(obstaceCellParent);
			obstacleCell.SetValues(o);
		}
		openButton.onClick.AddListener(() => {
			MainCameraController.instance.ChangeState(Const.CameraState.PlaceObstacle);
			isMoving = true;
			isOpen = true;
			openButton.gameObject.SetActive(false);
			closeButton.gameObject.SetActive(true);
		});
		closeButton.onClick.AddListener(() => {
			MainCameraController.instance.ChangeState(Const.CameraState.Scroll);
			isMoving = true;
			isOpen = false;
			openButton.gameObject.SetActive(true);
			closeButton.gameObject.SetActive(false);
		});
		openButton.gameObject.SetActive(true);
		closeButton.gameObject.SetActive(false);
	}

	private void Update () {
		if (!isMoving) return;
		var targetPosition = (isOpen) ? openPoint.position : closePoint.position;
		transform.position = Vector3.Lerp(
			transform.position,
			targetPosition,
			easing * Time.deltaTime
		);
		if (Vector3.Distance(targetPosition, transform.position) < 0.01f) {
			isMoving = false;
		}
	}
}
