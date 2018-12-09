using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomecommingPanel : MonoBehaviour {

	[SerializeField] private Button toChaseCameraButton;
	[SerializeField] private Text hpLabel;

	private void Start () {
		toChaseCameraButton.onClick.AddListener(() => {
			MainCameraController.instance.ChangeState(Const.CameraState.ChaseTarget);
		});
	}

	private void Update () {
		hpLabel.text = "<size=10>HP </size>" + Character.instance.HitPoint.ToString("f1") + "%";
	}

}
