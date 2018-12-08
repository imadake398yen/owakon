using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateStagePanel : MonoBehaviour {

	[SerializeField] private Button startButton;

	private void Start () {
		startButton.onClick.AddListener(() => {
			Model.Stage.ChangeState(Const.StageState.BraveManHomecoming);
			MainCameraController.instance.ChangeState(Const.CameraState.ChaseTarget);
		});
	}

}
