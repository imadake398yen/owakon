using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomecommingPanel : MonoBehaviour {

	[SerializeField] private Button toChaseCameraButton;

	void Start () {
		toChaseCameraButton.onClick.AddListener(() => {
			MainCameraController.instance.ToChaseState();
		});
	}

}
