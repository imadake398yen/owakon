using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Model;
using UnityEngine.Events;

public class UIManager : MonoBehaviour {

	[SerializeField] private GameObject
		createPanel,
		homecommingPanel;

	private Const.StageState lastStageState;

	private void Start () {
		Stage.OnChangeStateActions.Add(() => { OnChangeState(); });
	}

	private void OnChangeState () {
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
