using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomecommingPanel : SingletonMonoBehaviour<HomecommingPanel> {

	[SerializeField] private Button toChaseCameraButton;
	[SerializeField] private Text hpLabel;

	private void Start () {
		toChaseCameraButton.onClick.AddListener(() => {
			MainCameraController.instance.ChangeState(Const.CameraState.ChaseTarget);
		});
	}

	private void Update () {
		hpLabel.text = "<size=10>HP </size>" + Character.instance.HitPoint.ToString("f1") + "%";
		hpLabel.color = Color.Lerp (hpLabel.color, Color.white, 3f * Time.deltaTime);
	}

	public void Damage () {
		hpLabel.color = Color.red;
	}

}
