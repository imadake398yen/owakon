using UnityEngine.Events;
using System.Collections.Generic;

namespace Model {

	[System.Serializable]
	public class Stage {

		private static Stage _current = new Stage();
		public static void Init () { _current = new Stage(); }

		private List<Obstacle> _obstacles = new List<Obstacle>();
		public static List<Obstacle> Obstacles { get{ return _current._obstacles; } }

		private Const.StageState _state = Const.StageState.Create;
		public static Const.StageState State { get { return _current._state; } }
		public static void ChangeState (Const.StageState state) {
			_current._state = state;
			if (OnChangeStateActions.Count > 0) foreach(var a in OnChangeStateActions) a();
		}

		private List<UnityAction> _onChangeStateActions = new List<UnityAction>();
		public static List<UnityAction> OnChangeStateActions { get{ return _current._onChangeStateActions; } }

	}
}