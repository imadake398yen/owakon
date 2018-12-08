using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Model;

public class UIManager : MonoBehaviour {

	[SerializeField] private GameObject
		createPanel,
		homecommingPanel;

	private Const.StageState lastStageState;

	private void Update () {
		if (lastStageState != Stage.State) {
			switch (Stage.State) {
				case Const.StageState.Create:
					createPanel.SetActive(true);
					homecommingPanel.SetActive(false);
					break;
				case Const.StageState.BraveManHomecoming:
					createPanel.SetActive(false);
					homecommingPanel.SetActive(true);
					break;
			}
		} else return;
		lastStageState = Stage.State;
	}

}
