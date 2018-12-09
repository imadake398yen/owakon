using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Model;

public class CreateStagePanel : MonoBehaviour {

	[SerializeField] private Button startButton;

	private void Start () {
		startButton.onClick.AddListener(() => {
			Model.Stage.ChangeState(Const.StageState.BraveManHomecoming);
			MainCameraController.instance.ChangeState(Const.CameraState.ChaseTarget);
			foreach (var o in Stage.Obstacles) {
				o.ChangeState(Const.ObstacleState.Ready);
			}
		});
	}

}
