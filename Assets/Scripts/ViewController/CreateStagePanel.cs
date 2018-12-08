using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateStagePanel : MonoBehaviour {

	[SerializeField] private Button startButton;
	[SerializeField] private ObstacleCell obstaceCellPrefab;
	[SerializeField] private Transform obstaceCellParent;

	private void Start () {
		startButton.onClick.AddListener(() => {
			Model.Stage.ChangeState(Const.StageState.BraveManHomecoming);
			MainCameraController.instance.ChangeState(Const.CameraState.ChaseTarget);
		});
		foreach (var o in ResourceManager.Obstacles) {
			var obstacleCell = Instantiate(obstaceCellPrefab) as ObstacleCell;
			obstacleCell.transform.SetParentWithReset(obstaceCellParent);
			obstacleCell.SetValues(o);
		}
	}

}
